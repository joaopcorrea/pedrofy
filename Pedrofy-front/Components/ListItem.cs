using Pedrofy_front.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedrofy_front.Components
{
    public partial class ListItem : UserControl
    {
        private string idTrack;
        private string idAlbum;
        private string track;
        private string artist;
        private string album;
        private string duration;

        static HttpClient client;

        public ListItem()
        {
            InitializeComponent();

            client = new HttpClient();
        }

        public string IdTrack { get => idTrack; set => idTrack = value; }

        [Category("Custom Props")]
        public string IdAlbum { get => idAlbum; 
            set 
            { 
                idAlbum = value; 
                pnlImg.BackgroundImage = Image.FromFile($"../../../Assets/Images/Albums/{value}.jpg"); 
            } }
        [Category("Custom Props")]
        public string Track { get => track; set { track = value; lblTrack.Text = value; } }
        [Category("Custom Props")]
        public string Artist { get => artist; set { artist = value; lblArtist.Text = value; } }
        [Category("Custom Props")]
        public string Album { get => album; set { album = value; lblAlbum.Text = value; } }
        [Category("Custom Props")]
        public string Duration { get => duration; set 
            { 
                duration = value;

                int seconds = (int)Math.Floor(Convert.ToInt32(value) / 1000.0);

                lblMinutes.Text = $"{Convert.ToInt32(seconds) / 60}:{Convert.ToInt32(seconds) % 60:00}";
            } }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(15, 15, 15);
        }

        private async void btnAddQueue_Click(object sender, EventArgs e)
        {
            Track track = new Track()
            {
                IdTrack = IdTrack,
                IdAlbum = IdAlbum,
                StrTrack = Track,
                StrArtist = Artist,
                StrAlbum = Album,
                IntDuration = Duration,
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7124/track/queue");

            requestMessage.Content = JsonContent.Create(track);


            var response = await client.SendAsync(requestMessage);

            MessageBox.Show("Música adicionada na fila!");
        }

        private void btnAddQueue_MouseEnter(object sender, EventArgs e)
        {
            btnAddQueue.BackColor = Color.Transparent; 
        }
    }
}
