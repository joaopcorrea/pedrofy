using Pedrofy_front.Components;

namespace Pedrofy_front
{
    partial class formPedrofy
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
            this.pnlMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMusic
            // 
            this.pnlMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMusic.Controls.Add(this.btnPlay);
            this.pnlMusic.Controls.Add(this.pbMusicTimer);
            this.pnlMusic.Controls.Add(this.lblTotalMinutes);
            this.pnlMusic.Controls.Add(this.lblActualMinutes);
            this.pnlMusic.Controls.Add(this.btnNext);
            this.pnlMusic.Controls.Add(this.btnPrevious);
            this.pnlMusic.Controls.Add(this.btnPause);
            this.pnlMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMusic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMusic.Location = new System.Drawing.Point(-5, 612);
            this.pnlMusic.Name = "pnlMusic";
            this.pnlMusic.Size = new System.Drawing.Size(685, 125);
            this.pnlMusic.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Pedrofy_front.Properties.Resources.play_icon;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(334, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbMusicTimer
            // 
            this.pbMusicTimer.BackColor = System.Drawing.Color.Black;
            this.pbMusicTimer.BorderColor = System.Drawing.Color.Transparent;
            this.pbMusicTimer.Location = new System.Drawing.Point(243, 77);
            this.pbMusicTimer.Name = "pbMusicTimer";
            this.pbMusicTimer.Size = new System.Drawing.Size(220, 10);
            this.pbMusicTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbMusicTimer.TabIndex = 6;
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.AutoSize = true;
            this.lblTotalMinutes.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblTotalMinutes.Location = new System.Drawing.Point(495, 72);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(36, 15);
            this.lblTotalMinutes.TabIndex = 5;
            this.lblTotalMinutes.Text = "3:40";
            // 
            // lblActualMinutes
            // 
            this.lblActualMinutes.AutoSize = true;
            this.lblActualMinutes.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblActualMinutes.Location = new System.Drawing.Point(179, 72);
            this.lblActualMinutes.Name = "lblActualMinutes";
            this.lblActualMinutes.Size = new System.Drawing.Size(33, 15);
            this.lblActualMinutes.TabIndex = 4;
            this.lblActualMinutes.Text = "1:40";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Pedrofy_front.Properties.Resources.next_icon;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(406, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::Pedrofy_front.Properties.Resources.previous_icon;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(263, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 40);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::Pedrofy_front.Properties.Resources.pause_icon;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(334, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
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
            this.lblTitle.Font = new System.Drawing.Font("Gotham", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(215)))), ((int)(((byte)(98)))));
            this.lblTitle.Location = new System.Drawing.Point(84, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pedrofy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(215)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(284, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "®";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pedrofy_front.Properties.Resources.spotify_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 70);
            this.panel1.TabIndex = 3;
            // 
            // formPedrofy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(679, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMusic);
            this.Name = "formPedrofy";
            this.Text = "Pedrofy";
            this.Load += new System.EventHandler(this.formPedrofy_Load);
            this.pnlMusic.ResumeLayout(false);
            this.pnlMusic.PerformLayout();
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
    }
}