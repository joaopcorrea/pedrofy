namespace Pedrofy_front.Components
{
    partial class HistoryListItem
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImage = global::Pedrofy_front.Properties.Resources.trash_icon;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(525, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 30);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblMinutes.Location = new System.Drawing.Point(450, 24);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 13);
            this.lblMinutes.TabIndex = 10;
            this.lblMinutes.Text = "label4";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblAlbum.Location = new System.Drawing.Point(286, 25);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(42, 13);
            this.lblAlbum.TabIndex = 9;
            this.lblAlbum.Text = "label3";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.lblArtist.Location = new System.Drawing.Point(64, 37);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(42, 13);
            this.lblArtist.TabIndex = 8;
            this.lblArtist.Text = "label2";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTrack.Location = new System.Drawing.Point(64, 10);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(52, 17);
            this.lblTrack.TabIndex = 7;
            this.lblTrack.Text = "label1";
            // 
            // pnlImg
            // 
            this.pnlImg.BackgroundImage = global::Pedrofy_front.Properties.Resources._2337674;
            this.pnlImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImg.Location = new System.Drawing.Point(8, 5);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(50, 50);
            this.pnlImg.TabIndex = 6;
            // 
            // HistoryListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.pnlImg);
            this.Name = "HistoryListItem";
            this.Size = new System.Drawing.Size(570, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRemove;
        private Label lblMinutes;
        private Label lblAlbum;
        private Label lblArtist;
        private Label lblTrack;
        private Panel pnlImg;
    }
}
