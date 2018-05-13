namespace MP3_Tag_Editor
{
    partial class SearchResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1._ApplicationName = "Αποτελέσματα αναζήτησης";
            this.statusBar1._Icon = null;
            this.statusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar1.Location = new System.Drawing.Point(0, 0);
            this.statusBar1.LocationExit = 776;
            this.statusBar1.LocationMin = 756;
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(800, 25);
            this.statusBar1.TabIndex = 0;
            // 
            // CurrentCategoryInfo
            // 
            this.CurrentCategoryInfo.AutoSize = true;
            this.CurrentCategoryInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentCategoryInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentCategoryInfo.Location = new System.Drawing.Point(16, 90);
            this.CurrentCategoryInfo.Name = "CurrentCategoryInfo";
            this.CurrentCategoryInfo.Size = new System.Drawing.Size(774, 42);
            this.CurrentCategoryInfo.TabIndex = 49;
            this.CurrentCategoryInfo.Text = "Εδώ εμφανίζονται τα καλύτερα αποτελέσματα από το <service> για τις πληροφορίες το" +
    "υ τραγουδιού \r\nμε βάση τον καλλιτέχνη και τον τίτλο του";
            // 
            // CurrentCategory
            // 
            this.CurrentCategory.AutoSize = true;
            this.CurrentCategory.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentCategory.Location = new System.Drawing.Point(12, 41);
            this.CurrentCategory.Name = "CurrentCategory";
            this.CurrentCategory.Size = new System.Drawing.Size(477, 42);
            this.CurrentCategory.TabIndex = 48;
            this.CurrentCategory.Text = "Αποτελέσματα αναζήτησης";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(312, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Προηγούμενες τιμές";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(581, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Νέες τιμές";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Αποτελέσματα αναζήτησης";
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentCategoryInfo);
            this.Controls.Add(this.CurrentCategory);
            this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchResults";
            this.Text = "SearchResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusBar statusBar1;
        private System.Windows.Forms.Label CurrentCategoryInfo;
        private System.Windows.Forms.Label CurrentCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}