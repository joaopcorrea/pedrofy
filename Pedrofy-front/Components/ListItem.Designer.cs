namespace Pedrofy_front.Components
{
    partial class ListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlImg = new System.Windows.Forms.Panel();
            this.lblTrack = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.BackgroundImage = global::Pedrofy_front.Properties.Resources._2337674;
            this.pnlImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImg.Location = new System.Drawing.Point(5, 5);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(50, 50);
            this.pnlImg.TabIndex = 0;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTrack.Location = new System.Drawing.Point(61, 10);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(52, 17);
            this.lblTrack.TabIndex = 1;
            this.lblTrack.Text = "label1";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblArtist.Location = new System.Drawing.Point(61, 37);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(42, 13);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "label2";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblAlbum.Location = new System.Drawing.Point(283, 25);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(42, 13);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "label3";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblMinutes.Location = new System.Drawing.Point(447, 24);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 13);
            this.lblMinutes.TabIndex = 4;
            this.lblMinutes.Text = "label4";
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQueue.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQueue.BackgroundImage = global::Pedrofy_front.Properties.Resources.add_icon;
            this.btnAddQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQueue.FlatAppearance.BorderSize = 0;
            this.btnAddQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQueue.Location = new System.Drawing.Point(520, 10);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(40, 40);
            this.btnAddQueue.TabIndex = 5;
            this.btnAddQueue.UseVisualStyleBackColor = false;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.btnAddQueue);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.pnlImg);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(570, 60);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlImg;
        private Label lblTrack;
        private Label lblArtist;
        private Label lblAlbum;
        private Label lblMinutes;
        private Button btnAddQueue;
    }
}
