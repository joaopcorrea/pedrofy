using Pedrofy_front.Components;

namespace Pedrofy_front
{
    partial class FormPedrofy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMusic = new System.Windows.Forms.Panel();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.pnlAlbum = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbMusicTimer = new Pedrofy_front.Components.CustomProgressBar();
            this.lblTotalMinutes = new System.Windows.Forms.Label();
            this.lblActualMinutes = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTrackCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMusic.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMusic
            // 
            this.pnlMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMusic.Controls.Add(this.lblArtist);
            this.pnlMusic.Controls.Add(this.lblTrack);
            this.pnlMusic.Controls.Add(this.pnlAlbum);
            this.pnlMusic.Controls.Add(this.btnPlay);
            this.pnlMusic.Controls.Add(this.pbMusicTimer);
            this.pnlMusic.Controls.Add(this.lblTotalMinutes);
            this.pnlMusic.Controls.Add(this.lblActualMinutes);
            this.pnlMusic.Controls.Add(this.btnNext);
            this.pnlMusic.Controls.Add(this.btnPrevious);
            this.pnlMusic.Controls.Add(this.btnPause);
            this.pnlMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMusic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMusic.Location = new System.Drawing.Point(-5, 604);
            this.pnlMusic.Name = "pnlMusic";
            this.pnlMusic.Size = new System.Drawing.Size(896, 125);
            this.pnlMusic.TabIndex = 0;
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtist.Font = new System.Drawing.Font("Gotham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblArtist.Location = new System.Drawing.Point(101, 61);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(140, 15);
            this.lblArtist.TabIndex = 9;
            this.lblArtist.Text = "Imagine Dragons";
            // 
            // lblTrack
            // 
            this.lblTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrack.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTrack.Location = new System.Drawing.Point(100, 36);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(187, 20);
            this.lblTrack.TabIndex = 8;
            this.lblTrack.Text = "I Don\'t Know Why";
            // 
            // pnlAlbum
            // 
            this.pnlAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAlbum.Location = new System.Drawing.Point(25, 25);
            this.pnlAlbum.Name = "pnlAlbum";
            this.pnlAlbum.Size = new System.Drawing.Size(70, 70);
            this.pnlAlbum.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Pedrofy_front.Properties.Resources.play_icon;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(417, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 50);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // pbMusicTimer
            // 
            this.pbMusicTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMusicTimer.BackColor = System.Drawing.Color.Black;
            this.pbMusicTimer.BorderColor = System.Drawing.Color.Transparent;
            this.pbMusicTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMusicTimer.Location = new System.Drawing.Point(292, 77);
            this.pbMusicTimer.Name = "pbMusicTimer";
            this.pbMusicTimer.Size = new System.Drawing.Size(301, 5);
            this.pbMusicTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbMusicTimer.TabIndex = 6;
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMinutes.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblTotalMinutes.Location = new System.Drawing.Point(599, 72);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(37, 15);
            this.lblTotalMinutes.TabIndex = 5;
            this.lblTotalMinutes.Text = "3:40";
            // 
            // lblActualMinutes
            // 
            this.lblActualMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualMinutes.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblActualMinutes.Location = new System.Drawing.Point(250, 72);
            this.lblActualMinutes.Name = "lblActualMinutes";
            this.lblActualMinutes.Size = new System.Drawing.Size(37, 15);
            this.lblActualMinutes.TabIndex = 4;
            this.lblActualMinutes.Text = "1:40";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Pedrofy_front.Properties.Resources.next_icon;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(490, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::Pedrofy_front.Properties.Resources.previous_icon;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(347, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(46, 40);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::Pedrofy_front.Properties.Resources.pause_icon;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(417, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(51, 50);
            this.btnPause.TabIndex = 0;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // timerMusic
            // 
            this.timerMusic.Interval = 1000;
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gotham", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(215)))), ((int)(((byte)(98)))));
            this.lblTitle.Location = new System.Drawing.Point(65, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pedrofy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(215)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "®";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pedrofy_front.Properties.Resources.spotify_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(19, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 3;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.AutoScroll = true;
            this.pnlList.Location = new System.Drawing.Point(265, 175);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(620, 425);
            this.pnlList.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 604);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(21, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estatísticas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Histórico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Biblioteca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Gotham", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Biblioteca";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.textBox1.Location = new System.Drawing.Point(568, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 19);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label6.Location = new System.Drawing.Point(327, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "TÍTULO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label7.Location = new System.Drawing.Point(552, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ÁLBUM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label8.Location = new System.Drawing.Point(290, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "#";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.lblTrackCount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(246, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 76);
            this.panel3.TabIndex = 10;
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.AutoSize = true;
            this.lblTrackCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTrackCount.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrackCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTrackCount.Location = new System.Drawing.Point(527, 45);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(81, 16);
            this.lblTrackCount.TabIndex = 11;
            this.lblTrackCount.Text = "48 músicas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel4.Location = new System.Drawing.Point(265, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 1);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pedrofy_front.Properties.Resources.search_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(546, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Pedrofy_front.Properties.Resources.clock_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(723, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Gotham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(754, 100);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 19);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FormPedrofy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(884, 721);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlMusic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormPedrofy";
            this.Text = "Pedrofy";
            this.Load += new System.EventHandler(this.formPedrofy_Load);
            this.pnlMusic.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlMusic;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnPause;
        private Label lblTotalMinutes;
        private Label lblActualMinutes;
        private CustomProgressBar pbMusicTimer;
        private System.Windows.Forms.Timer timerMusic;
        private Button btnPlay;
        private Label lblTitle;
        private Label label1;
        private Panel panel1;
        private Panel pnlAlbum;
        private Label lblArtist;
        private Label lblTrack;
        private FlowLayoutPanel pnlList;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private Label lblTrackCount;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSearch;
    }
}