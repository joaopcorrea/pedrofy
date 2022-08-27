using Pedrofy_front.Components;
using Pedrofy_front.Models;
using Pedrofy_front.Repositories;
using System.Media;
using System.Text.Json;

namespace Pedrofy_front
{
    public partial class FormPedrofy : Form
    {
        int totalSeconds = 220;
        int currentSeconds = 0;
        string url;
        WMPLib.WindowsMediaPlayer player;
        static Track currentTrack;
        Repository repository;

        public FormPedrofy()
        {
            InitializeComponent();

            repository = new Repository();
            currentTrack = new Track();
            player = new WMPLib.WindowsMediaPlayer();

            btnPause.Visible = false;

            SyncInterface();
        }

        private void formPedrofy_Load(object sender, EventArgs e)
        {
            LoadLibrary();
        }

        private void lblMenuLibrary_Click(object sender, EventArgs e)
        {
            tbPages.SelectedIndex = 0;
            lblMenuLibrary.ForeColor = Color.FromArgb(250, 250, 250);
            lblMenuHistory.ForeColor = Color.FromArgb(186, 186, 186);
            lblMenuStatistic.ForeColor = Color.FromArgb(186, 186, 186);
        }

        private void lblMenuHistory_Click(object sender, EventArgs e)
        {
            tbPages.SelectedIndex = 1;
            lblMenuLibrary.ForeColor = Color.FromArgb(186, 186, 186);
            lblMenuHistory.ForeColor = Color.FromArgb(250, 250, 250);
            lblMenuStatistic.ForeColor = Color.FromArgb(186, 186, 186);

            LoadHistory();
        }

        private void lblMenuStatistic_Click(object sender, EventArgs e)
        {
            tbPages.SelectedIndex = 2;
            lblMenuLibrary.ForeColor = Color.FromArgb(186, 186, 186);
            lblMenuHistory.ForeColor = Color.FromArgb(186, 186, 186);
            lblMenuStatistic.ForeColor = Color.FromArgb(250, 250, 250);

            LoadStatistic();
        }

        #region Library
        private async void LoadLibrary(string filter = "")
        {
            Task taskLoadLibrary = new(async () =>
            {
                try
                {
                    pnlList.Invoke((MethodInvoker)delegate () { pnlList.Controls.Clear(); });

                    var tracks = await repository.GetAsync<List<Track>>(filter);

                    if (tracks != null)
                    {
                        foreach (var track in tracks)
                        {
                            pnlList.Invoke((MethodInvoker)delegate
                            {
                                pnlList.Controls.Add(new LibraryListItem()
                                {
                                    IdTrack = track.IdTrack,
                                    IdAlbum = track.IdAlbum,
                                    Track = track.StrTrack,
                                    Artist = track.StrArtist,
                                    Album = track.StrAlbum,
                                    Duration = track.IntDuration
                                });
                            });
                        }

                        lblHistoryCount.Invoke((MethodInvoker)delegate () { lblTrackCount.Text = $"{tracks.Count} músicas"; });
                    }
                    else
                    {
                        throw new Exception("Não foi possível retornar as músicas");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao carregar biblioteca");
                }
            });
            taskLoadLibrary.Start();
        }

        private void Play(bool fromStart = false)
        {
            try
            {
                if (string.IsNullOrEmpty(currentTrack.IdTrack))
                    return;

                if (fromStart)
                    currentSeconds = 0;

                btnPlay.Visible = false;
                btnPause.Visible = true;
                timerMusic.Start();

                player.controls.currentPosition = currentSeconds;
                player.controls.play();

                SyncInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tocar música");
            }
        }
        private void Pause()
        {
            try
            {
                if (string.IsNullOrEmpty(currentTrack.IdTrack))
                    return;

                btnPause.Visible = false;
                btnPlay.Visible = true;
                timerMusic.Stop();

                player.controls.pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao pausar música");
            }
        }
        private void Stop()
        {
            timerMusic.Stop();
            player.controls.stop();

            currentSeconds = 0;
            currentTrack = new();

            btnPlay.Visible = true;
            btnPause.Visible = false;

            SyncInterface();
        }
        private async void Previous()
        {
            try
            {
                if (currentSeconds < 3)
                {
                    var track = await repository.PostAsync<Track>("previous");
                    if (track != null)
                        ChangeCurrentTrack(track);
                }

                Play(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao buscar música anterior");
            }
        }
        private async void Next()
        {
            try
            {
                var track = await repository.PostAsync<Track>("next");

                if (track == null)
                {
                    Stop();
                    MessageBox.Show("A fila está vazia!");
                    return;
                }

                ChangeCurrentTrack(track);
                Play(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao buscar próxima música");
            }
        }
        private void ChangeCurrentTrack(Track track)
        {
            currentTrack = track;

            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            player.URL = $@"{projectDirectory}\Assets\Tracks\Albums\{currentTrack.IdAlbum}\{currentTrack.IdTrack}.mp3";
            currentSeconds = 0;
        }
        private void SyncInterface()
        {
            try
            {
                lblCurrentTrack.Text = currentTrack.StrTrack;
                lblCurrentArtist.Text = currentTrack.StrArtist;

                var workingDirectory = Environment.CurrentDirectory;
                var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                if (!string.IsNullOrEmpty(currentTrack.IdAlbum))
                    pnlCurrentAlbum.BackgroundImage = Image.FromFile($"{projectDirectory}/Assets/Images/Albums/{currentTrack.IdAlbum}.jpg");
                else
                    pnlCurrentAlbum.BackgroundImage = null;

                lblCurrentMinutes.Text = $"{currentSeconds / 60}:{currentSeconds % 60:00}";
                lblTotalMinutes.Text = $"{Convert.ToInt32(currentTrack.IntDuration) / 60}:{Convert.ToInt32(currentTrack.IntDuration) % 60:00}";
                FillTrackProgressBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao sincronizar interface");
            }
        }

        private void FillTrackProgressBar()
        {
            try
            {
                if (!string.IsNullOrEmpty(currentTrack.IntDuration))
                {
                    int value = Convert.ToInt32(100.0 * currentSeconds / Convert.ToInt32(currentTrack.IntDuration));
                    if (value < 0) value = 0;
                    if (value > 100) value = 100;
                    pbTrackTimer.Value = value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao preencher barra de progresso");
                throw ex;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            try
            {
                currentSeconds++;
                SyncInterface();

                if (currentSeconds == Convert.ToInt32(currentTrack.IntDuration))
                    Next();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao atualizar tempo da música");
            }
        }

        private void pbMusicTimer_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                var value = SetProgressBarClickValue(pbTrackTimer);
                int totalSeconds = Convert.ToInt32(currentTrack.IntDuration);

                currentSeconds = value * totalSeconds / 100;
                player.controls.currentPosition = currentSeconds;

                SyncInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao alterar tempo da música");
            }
        }

        private void pbVolume_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                var value = SetProgressBarClickValue(pbVolume);

                player.settings.volume = value;

                SyncInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao alterar volume");
            }
        }

        private int SetProgressBarClickValue(CustomProgressBar progressBar)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBar.Bounds.X);
            float calcFactor = progressBar.Width / (float)progressBar.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;
            progressBar.Value = Convert.ToInt32(relativeMouse);
            return progressBar.Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLibrary(txtSearch.Text);
        }
        #endregion

        #region History
        private async void LoadHistory()
        {
            try
            {
                Task taskLoadHistory = new(async () =>
                {
                    try
                    {
                        lstHistory.Invoke((MethodInvoker)delegate () { lstHistory.Controls.Clear(); });

                        var tracks = await repository.GetAsync<List<TrackHistory>>("", "history");

                        foreach (var track in tracks)
                        {
                            lstHistory.Invoke((MethodInvoker)delegate
                            {
                                lstHistory.Controls.Add(new HistoryListItem()
                                {
                                    IdHistory = track.IdHistory,
                                    IdTrack = track.IdTrack,
                                    IdAlbum = track.IdAlbum,
                                    Track = track.StrTrack,
                                    Artist = track.StrArtist,
                                    Album = track.StrAlbum,
                                    Duration = track.IntDuration
                                });
                            });
                        }

                        lblHistoryCount.Invoke((MethodInvoker) delegate() { lblHistoryCount.Text = $"{tracks.Count} músicas escutadas"; });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao carregar lista de histórico");
                    }
                });
                taskLoadHistory.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar histórico");
            }
        }
        #endregion

        #region Statistic
        private async void LoadStatistic()
        {
            try
            {
                var stats = await repository.GetAsync<Stats>("", "stats");
                lblMostListenedTrack.Text = stats.MostListenedTrack;
                lblMostListenedArtist.Text = stats.MostListenedArtist;
                lblMostListenedAlbum.Text = stats.MostListenedAlbum;
                lblMinutesListened.Text = (Convert.ToInt32(stats.SecondsListened) / 60).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar estatísticas");
            }
        }
        #endregion
    }
}