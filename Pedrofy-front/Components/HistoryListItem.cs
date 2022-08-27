﻿using Pedrofy_front.Models;
using Pedrofy_front.Repositories;
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
    public partial class HistoryListItem : UserControl
    {
        private string idTrack;
        private string idAlbum;
        private string track;
        private string artist;
        private string album;
        private string duration;

        Repository repository;

        public HistoryListItem()
        {
            InitializeComponent();

            repository = new Repository();
        }

        public int IdHistory { get; set; }

        public string IdTrack { get => idTrack; set => idTrack = value; }

        [Category("Custom Props")]
        public string IdAlbum
        {
            get => idAlbum;
            set
            {
                idAlbum = value;
                pnlImg.BackgroundImage = Image.FromFile($"../../../Assets/Images/Albums/{value}.jpg");
            }
        }
        [Category("Custom Props")]
        public string Track { get => track; set { track = value; lblTrack.Text = value; } }
        [Category("Custom Props")]
        public string Artist { get => artist; set { artist = value; lblArtist.Text = value; } }
        [Category("Custom Props")]
        public string Album { get => album; set { album = value; lblAlbum.Text = value; } }
        [Category("Custom Props")]
        public string Duration
        {
            get => duration; set
            {
                duration = value;

                var seconds = Convert.ToInt32(value);

                lblMinutes.Text = $"{seconds / 60}:{seconds % 60:00}";
            }
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(15, 15, 15);
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            var response = await repository.DeleteAsync("history/" + IdHistory);

            if (response)
                MessageBox.Show("Histórico removida com sucesso!");
            else
                MessageBox.Show("Não foi possível remover histórico!");
        }
    }
}
