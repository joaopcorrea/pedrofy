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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedrofy));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pbVolume = new Pedrofy_front.Components.CustomProgressBar();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.lblCurrentArtist = new System.Windows.Forms.Label();
            this.lblCurrentTrack = new System.Windows.Forms.Label();
            this.pnlCurrentAlbum = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbTrackTimer = new Pedrofy_front.Components.CustomProgressBar();
            this.lblTotalMinutes = new System.Windows.Forms.Label();
            this.lblCurrentMinutes = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleR = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuLibrary = new System.Windows.Forms.Label();
            this.lblMenuHistory = new System.Windows.Forms.Label();
            this.lblMenuStatistic = new System.Windows.Forms.Label();
            this.imgMenuHistory = new System.Windows.Forms.PictureBox();
            this.imgMenuStatistics = new System.Windows.Forms.PictureBox();
            this.imgMenuLibrary = new System.Windows.Forms.PictureBox();
            this.tbPages = new System.Windows.Forms.TabControl();
            this.Library = new System.Windows.Forms.TabPage();
            this.pnlLibrary = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlBackLibrary = new System.Windows.Forms.Panel();
            this.lblTrackCount = new System.Windows.Forms.Label();
            this.lblLibraryTitle = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.History = new System.Windows.Forms.TabPage();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHistoryCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.lblMinutesListened = new System.Windows.Forms.Label();
            this.lblMostListenedAlbum = new System.Windows.Forms.Label();
            this.lblMostListenedArtist = new System.Windows.Forms.Label();
            this.lblMostListenedTrack = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuLibrary)).BeginInit();
            this.tbPages.SuspendLayout();
            this.Library.SuspendLayout();
            this.pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.pnlBackLibrary.SuspendLayout();
            this.History.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.pbVolume);
            this.pnlControls.Controls.Add(this.pbSound);
            this.pnlControls.Controls.Add(this.lblCurrentArtist);
            this.pnlControls.Controls.Add(this.lblCurrentTrack);
            this.pnlControls.Controls.Add(this.pnlCurrentAlbum);
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Controls.Add(this.pbTrackTimer);
            this.pnlControls.Controls.Add(this.lblTotalMinutes);
            this.pnlControls.Controls.Add(this.lblCurrentMinutes);
            this.pnlControls.Controls.Add(this.btnNext);
            this.pnlControls.Controls.Add(this.btnPrevious);
            this.pnlControls.Controls.Add(this.btnPause);
            this.pnlControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlControls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlControls.Location = new System.Drawing.Point(-1, 604);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(886, 118);
            this.pnlControls.TabIndex = 0;
            // 
            // pbVolume
            // 
            this.pbVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbVolume.BackColor = System.Drawing.Color.Black;
            this.pbVolume.BorderColor = System.Drawing.Color.Transparent;
            this.pbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolume.Location = new System.Drawing.Point(747, 54);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(108, 5);
            this.pbVolume.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbVolume.TabIndex = 11;
            this.pbVolume.Value = 100;
            this.pbVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbVolume_MouseDown);
            // 
            // pbSound
            // 
            this.pbSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSound.BackgroundImage = global::Pedrofy_front.Properties.Resources.sound_icon;
            this.pbSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSound.Location = new System.Drawing.Point(718, 46);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(20, 20);
            this.pbSound.TabIndex = 10;
            this.pbSound.TabStop = false;
            // 
            // lblCurrentArtist
            // 
            this.lblCurrentArtist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentArtist.Font = new System.Drawing.Font("Gotham", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblCurrentArtist.Location = new System.Drawing.Point(101, 66);
            this.lblCurrentArtist.Name = "lblCurrentArtist";
            this.lblCurrentArtist.Size = new System.Drawing.Size(128, 15);
            this.lblCurrentArtist.TabIndex = 9;
            this.lblCurrentArtist.Text = "Imagine Dragons";
            // 
            // lblCurrentTrack
            // 
            this.lblCurrentTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentTrack.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblCurrentTrack.Location = new System.Drawing.Point(101, 39);
            this.lblCurrentTrack.Name = "lblCurrentTrack";
            this.lblCurrentTrack.Size = new System.Drawing.Size(175, 20);
            this.lblCurrentTrack.TabIndex = 8;
            this.lblCurrentTrack.Text = "I Don\'t Know Why";
            // 
            // pnlCurrentAlbum
            // 
            this.pnlCurrentAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCurrentAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCurrentAlbum.Location = new System.Drawing.Point(24, 24);
            this.pnlCurrentAlbum.Name = "pnlCurrentAlbum";
            this.pnlCurrentAlbum.Size = new System.Drawing.Size(70, 70);
            this.pnlCurrentAlbum.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Pedrofy_front.Properties.Resources.play_icon;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(421, 24);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbTrackTimer
            // 
            this.pbTrackTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbTrackTimer.BackColor = System.Drawing.Color.Black;
            this.pbTrackTimer.BorderColor = System.Drawing.Color.Transparent;
            this.pbTrackTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrackTimer.Location = new System.Drawing.Point(299, 83);
            this.pbTrackTimer.Name = "pbTrackTimer";
            this.pbTrackTimer.Size = new System.Drawing.Size(289, 5);
            this.pbTrackTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTrackTimer.TabIndex = 6;
            this.pbTrackTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMusicTimer_MouseDown);
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMinutes.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblTotalMinutes.Location = new System.Drawing.Point(597, 78);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(37, 15);
            this.lblTotalMinutes.TabIndex = 5;
            this.lblTotalMinutes.Text = "3:40";
            // 
            // lblCurrentMinutes
            // 
            this.lblCurrentMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentMinutes.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblCurrentMinutes.Location = new System.Drawing.Point(256, 78);
            this.lblCurrentMinutes.Name = "lblCurrentMinutes";
            this.lblCurrentMinutes.Size = new System.Drawing.Size(37, 15);
            this.lblCurrentMinutes.TabIndex = 4;
            this.lblCurrentMinutes.Text = "1:40";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Pedrofy_front.Properties.Resources.next_icon;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(477, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::Pedrofy_front.Properties.Resources.previous_icon;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(365, 29);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 30);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::Pedrofy_front.Properties.Resources.pause_icon;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(421, 24);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 0;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
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
            // lblTitleR
            // 
            this.lblTitleR.AutoSize = true;
            this.lblTitleR.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(215)))), ((int)(((byte)(98)))));
            this.lblTitleR.Location = new System.Drawing.Point(211, 28);
            this.lblTitleR.Name = "lblTitleR";
            this.lblTitleR.Size = new System.Drawing.Size(18, 16);
            this.lblTitleR.TabIndex = 2;
            this.lblTitleR.Text = "®";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Pedrofy_front.Properties.Resources.spotify_logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(19, 13);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(50, 50);
            this.pnlLogo.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pnlMenu.Controls.Add(this.lblMenuLibrary);
            this.pnlMenu.Controls.Add(this.lblMenuHistory);
            this.pnlMenu.Controls.Add(this.lblMenuStatistic);
            this.pnlMenu.Controls.Add(this.imgMenuHistory);
            this.pnlMenu.Controls.Add(this.imgMenuStatistics);
            this.pnlMenu.Controls.Add(this.imgMenuLibrary);
            this.pnlMenu.Controls.Add(this.lblTitleR);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.lblTitle);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(245, 604);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblMenuLibrary
            // 
            this.lblMenuLibrary.AutoSize = true;
            this.lblMenuLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuLibrary.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblMenuLibrary.Location = new System.Drawing.Point(52, 102);
            this.lblMenuLibrary.Name = "lblMenuLibrary";
            this.lblMenuLibrary.Size = new System.Drawing.Size(110, 22);
            this.lblMenuLibrary.TabIndex = 4;
            this.lblMenuLibrary.Text = "Biblioteca";
            this.lblMenuLibrary.Click += new System.EventHandler(this.lblMenuLibrary_Click);
            // 
            // lblMenuHistory
            // 
            this.lblMenuHistory.AutoSize = true;
            this.lblMenuHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuHistory.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblMenuHistory.Location = new System.Drawing.Point(52, 152);
            this.lblMenuHistory.Name = "lblMenuHistory";
            this.lblMenuHistory.Size = new System.Drawing.Size(99, 22);
            this.lblMenuHistory.TabIndex = 5;
            this.lblMenuHistory.Text = "Histórico";
            this.lblMenuHistory.Click += new System.EventHandler(this.lblMenuHistory_Click);
            // 
            // lblMenuStatistic
            // 
            this.lblMenuStatistic.AutoSize = true;
            this.lblMenuStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenuStatistic.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblMenuStatistic.Location = new System.Drawing.Point(52, 202);
            this.lblMenuStatistic.Name = "lblMenuStatistic";
            this.lblMenuStatistic.Size = new System.Drawing.Size(122, 22);
            this.lblMenuStatistic.TabIndex = 6;
            this.lblMenuStatistic.Text = "Estatísticas";
            this.lblMenuStatistic.Click += new System.EventHandler(this.lblMenuStatistic_Click);
            // 
            // imgMenuHistory
            // 
            this.imgMenuHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMenuHistory.BackgroundImage")));
            this.imgMenuHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMenuHistory.Location = new System.Drawing.Point(24, 152);
            this.imgMenuHistory.Name = "imgMenuHistory";
            this.imgMenuHistory.Size = new System.Drawing.Size(22, 22);
            this.imgMenuHistory.TabIndex = 9;
            this.imgMenuHistory.TabStop = false;
            // 
            // imgMenuStatistics
            // 
            this.imgMenuStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMenuStatistics.BackgroundImage")));
            this.imgMenuStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMenuStatistics.Location = new System.Drawing.Point(24, 202);
            this.imgMenuStatistics.Name = "imgMenuStatistics";
            this.imgMenuStatistics.Size = new System.Drawing.Size(22, 22);
            this.imgMenuStatistics.TabIndex = 8;
            this.imgMenuStatistics.TabStop = false;
            // 
            // imgMenuLibrary
            // 
            this.imgMenuLibrary.BackgroundImage = global::Pedrofy_front.Properties.Resources.library_icon;
            this.imgMenuLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgMenuLibrary.Location = new System.Drawing.Point(22, 102);
            this.imgMenuLibrary.Name = "imgMenuLibrary";
            this.imgMenuLibrary.Size = new System.Drawing.Size(22, 22);
            this.imgMenuLibrary.TabIndex = 7;
            this.imgMenuLibrary.TabStop = false;
            // 
            // tbPages
            // 
            this.tbPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPages.Controls.Add(this.Library);
            this.tbPages.Controls.Add(this.History);
            this.tbPages.Controls.Add(this.Statistics);
            this.tbPages.Location = new System.Drawing.Point(241, -24);
            this.tbPages.Name = "tbPages";
            this.tbPages.SelectedIndex = 0;
            this.tbPages.Size = new System.Drawing.Size(648, 632);
            this.tbPages.TabIndex = 1;
            this.tbPages.TabStop = false;
            // 
            // Library
            // 
            this.Library.Controls.Add(this.pnlLibrary);
            this.Library.Location = new System.Drawing.Point(4, 24);
            this.Library.Name = "Library";
            this.Library.Padding = new System.Windows.Forms.Padding(3);
            this.Library.Size = new System.Drawing.Size(640, 604);
            this.Library.TabIndex = 0;
            this.Library.Text = "tabPage1";
            this.Library.UseVisualStyleBackColor = true;
            // 
            // pnlLibrary
            // 
            this.pnlLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlLibrary.Controls.Add(this.btnSearch);
            this.pnlLibrary.Controls.Add(this.pictureBox2);
            this.pnlLibrary.Controls.Add(this.pbSearch);
            this.pnlLibrary.Controls.Add(this.pnlLine);
            this.pnlLibrary.Controls.Add(this.label8);
            this.pnlLibrary.Controls.Add(this.label7);
            this.pnlLibrary.Controls.Add(this.label6);
            this.pnlLibrary.Controls.Add(this.txtSearch);
            this.pnlLibrary.Controls.Add(this.pnlBackLibrary);
            this.pnlLibrary.Controls.Add(this.pnlList);
            this.pnlLibrary.Location = new System.Drawing.Point(0, 0);
            this.pnlLibrary.Name = "pnlLibrary";
            this.pnlLibrary.Size = new System.Drawing.Size(640, 604);
            this.pnlLibrary.TabIndex = 16;
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
            this.btnSearch.Location = new System.Drawing.Point(506, 102);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 19);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Pedrofy_front.Properties.Resources.clock_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(475, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pbSearch
            // 
            this.pbSearch.BackgroundImage = global::Pedrofy_front.Properties.Resources.search_icon;
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearch.Location = new System.Drawing.Point(304, 102);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(15, 15);
            this.pbSearch.TabIndex = 22;
            this.pbSearch.TabStop = false;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pnlLine.Location = new System.Drawing.Point(17, 170);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(570, 1);
            this.pnlLine.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label8.Location = new System.Drawing.Point(42, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label7.Location = new System.Drawing.Point(304, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ÁLBUM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label6.Location = new System.Drawing.Point(79, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "TÍTULO";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSearch.Location = new System.Drawing.Point(325, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 19);
            this.txtSearch.TabIndex = 16;
            // 
            // pnlBackLibrary
            // 
            this.pnlBackLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlBackLibrary.Controls.Add(this.lblTrackCount);
            this.pnlBackLibrary.Controls.Add(this.lblLibraryTitle);
            this.pnlBackLibrary.Location = new System.Drawing.Point(0, 2);
            this.pnlBackLibrary.Name = "pnlBackLibrary";
            this.pnlBackLibrary.Size = new System.Drawing.Size(639, 76);
            this.pnlBackLibrary.TabIndex = 20;
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.AutoSize = true;
            this.lblTrackCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTrackCount.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrackCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTrackCount.Location = new System.Drawing.Point(527, 45);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(73, 16);
            this.lblTrackCount.TabIndex = 11;
            this.lblTrackCount.Text = "0 músicas";
            // 
            // lblLibraryTitle
            // 
            this.lblLibraryTitle.AutoSize = true;
            this.lblLibraryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblLibraryTitle.Font = new System.Drawing.Font("Gotham", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLibraryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblLibraryTitle.Location = new System.Drawing.Point(5, 13);
            this.lblLibraryTitle.Name = "lblLibraryTitle";
            this.lblLibraryTitle.Size = new System.Drawing.Size(268, 54);
            this.lblLibraryTitle.TabIndex = 5;
            this.lblLibraryTitle.Text = "Biblioteca";
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.AutoScroll = true;
            this.pnlList.Location = new System.Drawing.Point(17, 177);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(622, 424);
            this.pnlList.TabIndex = 15;
            // 
            // History
            // 
            this.History.Controls.Add(this.pnlHistory);
            this.History.Location = new System.Drawing.Point(4, 24);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(640, 604);
            this.History.TabIndex = 1;
            this.History.Text = "tabPage2";
            this.History.UseVisualStyleBackColor = true;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlHistory.Controls.Add(this.pictureBox1);
            this.pnlHistory.Controls.Add(this.panel1);
            this.pnlHistory.Controls.Add(this.label1);
            this.pnlHistory.Controls.Add(this.label2);
            this.pnlHistory.Controls.Add(this.label3);
            this.pnlHistory.Controls.Add(this.lstHistory);
            this.pnlHistory.Controls.Add(this.panel2);
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(640, 604);
            this.pnlHistory.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pedrofy_front.Properties.Resources.clock_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(477, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Location = new System.Drawing.Point(19, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 1);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(306, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ÁLBUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(81, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "TÍTULO";
            // 
            // lstHistory
            // 
            this.lstHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistory.AutoScroll = true;
            this.lstHistory.Location = new System.Drawing.Point(17, 118);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(622, 483);
            this.lstHistory.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.lblHistoryCount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 76);
            this.panel2.TabIndex = 18;
            // 
            // lblHistoryCount
            // 
            this.lblHistoryCount.AutoSize = true;
            this.lblHistoryCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblHistoryCount.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistoryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblHistoryCount.Location = new System.Drawing.Point(352, 45);
            this.lblHistoryCount.Name = "lblHistoryCount";
            this.lblHistoryCount.Size = new System.Drawing.Size(144, 16);
            this.lblHistoryCount.TabIndex = 21;
            this.lblHistoryCount.Text = "0 músicas escutadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Font = new System.Drawing.Font("Gotham", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 54);
            this.label5.TabIndex = 5;
            this.label5.Text = "Histórico";
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Statistics.Controls.Add(this.lblMinutesListened);
            this.Statistics.Controls.Add(this.lblMostListenedAlbum);
            this.Statistics.Controls.Add(this.lblMostListenedArtist);
            this.Statistics.Controls.Add(this.lblMostListenedTrack);
            this.Statistics.Controls.Add(this.label12);
            this.Statistics.Controls.Add(this.label11);
            this.Statistics.Controls.Add(this.label10);
            this.Statistics.Controls.Add(this.label9);
            this.Statistics.Controls.Add(this.panel3);
            this.Statistics.Location = new System.Drawing.Point(4, 24);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(640, 604);
            this.Statistics.TabIndex = 2;
            this.Statistics.Text = "tabPage3";
            // 
            // lblMinutesListened
            // 
            this.lblMinutesListened.AutoSize = true;
            this.lblMinutesListened.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutesListened.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinutesListened.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblMinutesListened.Location = new System.Drawing.Point(13, 524);
            this.lblMinutesListened.Name = "lblMinutesListened";
            this.lblMinutesListened.Size = new System.Drawing.Size(35, 36);
            this.lblMinutesListened.TabIndex = 27;
            this.lblMinutesListened.Text = "  ";
            // 
            // lblMostListenedAlbum
            // 
            this.lblMostListenedAlbum.AutoSize = true;
            this.lblMostListenedAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblMostListenedAlbum.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostListenedAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblMostListenedAlbum.Location = new System.Drawing.Point(13, 399);
            this.lblMostListenedAlbum.Name = "lblMostListenedAlbum";
            this.lblMostListenedAlbum.Size = new System.Drawing.Size(35, 36);
            this.lblMostListenedAlbum.TabIndex = 26;
            this.lblMostListenedAlbum.Text = "  ";
            // 
            // lblMostListenedArtist
            // 
            this.lblMostListenedArtist.AutoSize = true;
            this.lblMostListenedArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblMostListenedArtist.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostListenedArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblMostListenedArtist.Location = new System.Drawing.Point(13, 277);
            this.lblMostListenedArtist.Name = "lblMostListenedArtist";
            this.lblMostListenedArtist.Size = new System.Drawing.Size(35, 36);
            this.lblMostListenedArtist.TabIndex = 25;
            this.lblMostListenedArtist.Text = "  ";
            // 
            // lblMostListenedTrack
            // 
            this.lblMostListenedTrack.AutoSize = true;
            this.lblMostListenedTrack.BackColor = System.Drawing.Color.Transparent;
            this.lblMostListenedTrack.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostListenedTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblMostListenedTrack.Location = new System.Drawing.Point(11, 140);
            this.lblMostListenedTrack.Name = "lblMostListenedTrack";
            this.lblMostListenedTrack.Size = new System.Drawing.Size(35, 36);
            this.lblMostListenedTrack.TabIndex = 24;
            this.lblMostListenedTrack.Text = "  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label12.Location = new System.Drawing.Point(13, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "Minutos escutados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label11.Location = new System.Drawing.Point(13, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(318, 31);
            this.label11.TabIndex = 22;
            this.label11.Text = "Album mais escutado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label10.Location = new System.Drawing.Point(13, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Artista mais escutado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.label9.Location = new System.Drawing.Point(11, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Música mais escutada:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 76);
            this.panel3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Gotham", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(5, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 54);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estatísticas";
            // 
            // FormPedrofy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(884, 721);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.tbPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPedrofy";
            this.Text = "Pedrofy";
            this.Load += new System.EventHandler(this.formPedrofy_Load);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuLibrary)).EndInit();
            this.tbPages.ResumeLayout(false);
            this.Library.ResumeLayout(false);
            this.pnlLibrary.ResumeLayout(false);
            this.pnlLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.pnlBackLibrary.ResumeLayout(false);
            this.pnlBackLibrary.PerformLayout();
            this.History.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Statistics.ResumeLayout(false);
            this.Statistics.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlControls;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnPause;
        private Label lblTotalMinutes;
        private Label lblCurrentMinutes;
        private CustomProgressBar pbTrackTimer;
        private System.Windows.Forms.Timer timerMusic;
        private Button btnPlay;
        private Label lblTitle;
        private Label lblTitleR;
        private Panel pnlLogo;
        private Panel pnlCurrentAlbum;
        private Label lblCurrentArtist;
        private Label lblCurrentTrack;
        private Panel pnlMenu;
        private Label lblMenuStatistic;
        private Label lblMenuHistory;
        private Label lblMenuLibrary;
        private PictureBox pbSound;
        private CustomProgressBar pbVolume;
        private TabControl tbPages;
        private TabPage Library;
        private TabPage History;
        private Panel pnlHistory;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel lstHistory;
        private Panel panel2;
        private Label label5;
        private Panel pnlLibrary;
        private Button btnSearch;
        private PictureBox pictureBox2;
        private PictureBox pbSearch;
        private Panel pnlLine;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtSearch;
        private Panel pnlBackLibrary;
        private Label lblTrackCount;
        private Label lblLibraryTitle;
        private FlowLayoutPanel pnlList;
        private TabPage Statistics;
        private Panel panel3;
        private Label label4;
        private PictureBox imgMenuHistory;
        private PictureBox imgMenuStatistics;
        private PictureBox imgMenuLibrary;
        private Label lblHistoryCount;
        private Label lblMinutesListened;
        private Label lblMostListenedAlbum;
        private Label lblMostListenedArtist;
        private Label lblMostListenedTrack;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}