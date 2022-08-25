using Pedrofy_front.Components;
using Pedrofy_front.Models;
using System.Text.Json;

namespace Pedrofy_front
{
    public partial class FormPedrofy : Form
    {
        int totalSeconds = 220;
        int actualSeconds = 0;

        string url;

        static HttpClient client;

        public FormPedrofy()
        {
            InitializeComponent();

            client = new HttpClient();

            url = "https://localhost:7124/track";

            SyncInterface();

            btnPause.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Visible = false;
            btnPlay.Visible = true;
            timerMusic.Stop();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private async void formPedrofy_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync(url);
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
            lblTotalMinutes.Text = $"{totalSeconds/60}:{totalSeconds%60}";
            lblActualMinutes.Text = $"{actualSeconds / 60}:{actualSeconds % 60}";
            FillMusicProgressBar();
        }

        private void FillMusicProgressBar()
        {
            int value = Convert.ToInt32(100.0 * actualSeconds / totalSeconds);
            if (value < 0) value = 0;
            if (value > 100) value = 100;
            pbMusicTimer.Value = value;
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            actualSeconds++;
            SyncInterface();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnPause.Visible = true;
            timerMusic.Start();
        }
    }
}