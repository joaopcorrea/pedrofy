using Pedrofy_front.Components;
using Pedrofy_front.Models;
using System.Media;
using System.Text.Json;

namespace Pedrofy_front
{
    public partial class FormPedrofy : Form
    {
        int totalSeconds = 220;
        int actualSeconds = 0;

        string url;

        static HttpClient client;

        WMPLib.WindowsMediaPlayer player;

        static Track actualTrack;

        public FormPedrofy()
        {
            InitializeComponent();

            client = new HttpClient();

            url = "https://localhost:7124/track";

            actualTrack = new Track();

            SyncInterface();

            btnPause.Visible = false;

            player = new WMPLib.WindowsMediaPlayer();

            pbVolume.Value = player.settings.volume;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(actualTrack.IdTrack))
                return;

            btnPause.Visible = false;
            btnPlay.Visible = true;
            timerMusic.Stop();

            player.controls.pause();
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            var response = await client.PostAsync(url + "/previous", null);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                actualTrack = JsonSerializer.Deserialize<Track>(content);
                player.URL = $@"C:\Users\joaop\Documents\albums\{actualTrack.IdAlbum}\{actualTrack.IdTrack}.mp3";
            }
            else
            {
                actualTrack = new();
            }

            SyncInterface();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            var response = await client.PostAsync(url+"/next", null);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                actualTrack = JsonSerializer.Deserialize<Track>(content);
                player.URL = $@"C:\Users\joaop\Documents\albums\{actualTrack.IdAlbum}\{actualTrack.IdTrack}.mp3";

                actualSeconds = 0;
                btnPlay.Visible = false;
                btnPause.Visible = true;
                timerMusic.Start();
            }
            else
            {
                actualTrack = new();
            }

            SyncInterface();
        }

        private async void formPedrofy_Load(object sender, EventArgs e)
        {
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var tracks = JsonSerializer.Deserialize<List<Track>>(json);

                foreach (var track in tracks)
                {
                    pnlList.Controls.Add(new ListItem()
                    {
                        IdTrack = track.IdTrack,
                        IdAlbum = track.IdAlbum,
                        Track = track.StrTrack,
                        Artist = track.StrArtist,
                        Album = track.StrAlbum,
                        Duration = track.IntDuration
                    });
                }
            }
            else
                throw new Exception("erro");

            
        }

        private void SyncInterface()
        {
            lblTrack.Text = actualTrack.StrTrack;
            lblArtist.Text = actualTrack.StrArtist;
            if (!string.IsNullOrEmpty(actualTrack.IdAlbum))
                pnlAlbum.BackgroundImage = Image.FromFile($"../../../Assets/Images/Albums/{actualTrack.IdAlbum}.jpg");

            lblTotalMinutes.Text = $"{Convert.ToInt32(actualTrack.IntDuration)/60000}:{Convert.ToInt32(actualTrack.IntDuration) %60000:00}";
            lblActualMinutes.Text = $"{actualSeconds / 60}:{actualSeconds % 60:00}";
            FillMusicProgressBar();
        }

        private void FillMusicProgressBar()
        {
            if (!string.IsNullOrEmpty(actualTrack.IntDuration))
            {
                int value = Convert.ToInt32(100.0 * actualSeconds / (Convert.ToInt32(actualTrack.IntDuration)/1000));
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                pbMusicTimer.Value = value;
            }
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            actualSeconds++;
            SyncInterface();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(actualTrack.IdTrack))
                return;

            btnPlay.Visible = false;
            btnPause.Visible = true;
            timerMusic.Start();

            player.controls.play();
        }

        private void pbMusicTimer_MouseDown(object sender, MouseEventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - pbMusicTimer.Bounds.X);
            float calcFactor = pbMusicTimer.Width / (float)pbMusicTimer.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;

            pbMusicTimer.Value = Convert.ToInt32(relativeMouse);


            int totalSeconds = Convert.ToInt32(actualTrack.IntDuration) / 1000;

            actualSeconds = pbMusicTimer.Value * totalSeconds / 100;

            player.controls.currentPosition = actualSeconds;
        }

        private void pbVolume_MouseDown(object sender, MouseEventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - pbVolume.Bounds.X);
            float calcFactor = pbVolume.Width / (float)pbVolume.Maximum;
            float relativeMouse = absoluteMouse / calcFactor;

            pbVolume.Value = Convert.ToInt32(relativeMouse);

            player.settings.volume = pbVolume.Value;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            pnlList.Controls.Clear();

            var response = await client.GetAsync(url+"?filter="+txtSearch.Text);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var tracks = JsonSerializer.Deserialize<List<Track>>(json);

                foreach (var track in tracks)
                {
                    pnlList.Controls.Add(new ListItem()
                    {
                        IdTrack = track.IdTrack,
                        IdAlbum = track.IdAlbum,
                        Track = track.StrTrack,
                        Artist = track.StrArtist,
                        Album = track.StrAlbum,
                        Duration = track.IntDuration
                    });
                }
            }
            else
                throw new Exception("erro");
        }
    }
}