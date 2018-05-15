namespace MP3_Tag_Editor
{
    partial class DiscogsSongInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar1 = new MP3_Tag_Editor.StatusBar();
            this.CurrentCategoryInfo = new System.Windows.Forms.Label();
            this.CurrentCategory = new System.Windows.Forms.Label();
            this.songInfoCard1 = new MP3_Tag_Editor.SongInfoCard();
            this.songInfoCard2 = new MP3_Tag_Editor.SongInfoCard();
            this.songInfoCard3 = new MP3_Tag_Editor.SongInfoCard();
            this.songInfoCard4 = new MP3_Tag_Editor.SongInfoCard();
            this.songInfoCard5 = new MP3_Tag_Editor.SongInfoCard();
            this.songInfoCard6 = new MP3_Tag_Editor.SongInfoCard();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1._ApplicationName = "Πληροφορίες τραγουδιού";
            this.statusBar1._Icon = null;
            this.statusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar1.Location = new System.Drawing.Point(0, 0);
            this.statusBar1.LocationExit = 705;
            this.statusBar1.LocationMin = 685;
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(588, 25);
            this.statusBar1.TabIndex = 0;
            // 
            // CurrentCategoryInfo
            // 
            this.CurrentCategoryInfo.AutoSize = true;
            this.CurrentCategoryInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentCategoryInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentCategoryInfo.Location = new System.Drawing.Point(16, 94);
            this.CurrentCategoryInfo.Name = "CurrentCategoryInfo";
            this.CurrentCategoryInfo.Size = new System.Drawing.Size(557, 42);
            this.CurrentCategoryInfo.TabIndex = 19;
            this.CurrentCategoryInfo.Text = "Εδώ εμφανίζονται τα καλύτερα αποτελέσματα από το Discogs σχετικά με \r\nτις πληροφο" +
    "ρίες  με  βάση τον καλλιτέχνη και τον τίτλο του";
            // 
            // CurrentCategory
            // 
            this.CurrentCategory.AutoSize = true;
            this.CurrentCategory.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentCategory.Location = new System.Drawing.Point(12, 45);
            this.CurrentCategory.Name = "CurrentCategory";
            this.CurrentCategory.Size = new System.Drawing.Size(477, 42);
            this.CurrentCategory.TabIndex = 18;
            this.CurrentCategory.Text = "Αποτελέσματα αναζήτησης";
            // 
            // songInfoCard1
            // 
            this.songInfoCard1.Location = new System.Drawing.Point(19, 155);
            this.songInfoCard1.Name = "songInfoCard1";
            this.songInfoCard1.Size = new System.Drawing.Size(257, 91);
            this.songInfoCard1.TabIndex = 20;
            // 
            // songInfoCard2
            // 
            this.songInfoCard2.Location = new System.Drawing.Point(302, 155);
            this.songInfoCard2.Name = "songInfoCard2";
            this.songInfoCard2.Size = new System.Drawing.Size(257, 91);
            this.songInfoCard2.TabIndex = 21;
            // 
            // songInfoCard3
            // 
            this.songInfoCard3.Location = new System.Drawing.Point(20, 270);
            this.songInfoCard3.Name = "songInfoCard3";
            this.songInfoCard3.Size = new System.Drawing.Size(257, 91);
            this.songInfoCard3.TabIndex = 21;
            // 
            // songInfoCard4
            // 
            this.songInfoCard4.Location = new System.Drawing.Point(302, 270);
            this.songInfoCard4.Name = "songInfoCard4";
            this.songInfoCard4.Size = new System.Drawing.Size(257, 91);
            this.songInfoCard4.TabIndex = 22;
            // 
            // songInfoCard5
            // 
            this.songInfoCard5.Location = new System.Drawing.Point(20, 380);
            this.songInfoCard5.Name = "songInfoCard5";
            this.songInfoCard5.Size = new System.Drawing.Size(257, 91);
            this.songInfoCard5.TabIndex = 23;
            // 
            // songInfoCard6
            // 
            this.songInfoCard6.Location = new System.Drawing.Point(302, 380);
            this.songInfoCard6.Name = "songInfoCard6";
            this.songInfoCard6.Size = new System.Drawing.Size(257, 91);
            this.songInfoCard6.TabIndex = 24;
            // 
            // DiscogsSongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(588, 506);
            this.Controls.Add(this.songInfoCard6);
            this.Controls.Add(this.songInfoCard5);
            this.Controls.Add(this.songInfoCard4);
            this.Controls.Add(this.songInfoCard3);
            this.Controls.Add(this.songInfoCard2);
            this.Controls.Add(this.songInfoCard1);
            this.Controls.Add(this.CurrentCategoryInfo);
            this.Controls.Add(this.CurrentCategory);
            this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscogsSongInfo";
            this.Text = "DiscogsSongInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusBar statusBar1;
        private System.Windows.Forms.Label CurrentCategoryInfo;
        private System.Windows.Forms.Label CurrentCategory;
        private SongInfoCard songInfoCard1;
        private SongInfoCard songInfoCard2;
        private SongInfoCard songInfoCard3;
        private SongInfoCard songInfoCard4;
        private SongInfoCard songInfoCard5;
        private SongInfoCard songInfoCard6;
    }
}