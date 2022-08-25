using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public ListItem()
        {
            InitializeComponent();
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
        public string Duration { get => duration; set { duration = value; lblMinutes.Text = value; } }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(12, 12, 12);
        }
    }
}
