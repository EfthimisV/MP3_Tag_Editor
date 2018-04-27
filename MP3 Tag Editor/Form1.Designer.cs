namespace MP3_Tag_Editor
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mylibrary = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.PictureBox();
            this.infopanel = new System.Windows.Forms.Panel();
            this.CurrentCategoryInfo = new System.Windows.Forms.Label();
            this.CurrentCategory = new System.Windows.Forms.Label();
            this.hamburgerMenu1 = new MP3_Tag_Editor.HamburgerMenu();
            this.searchButton1 = new MP3_Tag_Editor.SearchButton();
            this.searchBar1 = new MP3_Tag_Editor.SearchBar();
            this.hamburgerItem3 = new MP3_Tag_Editor.HamburgerItem();
            this.hamburgerItem2 = new MP3_Tag_Editor.HamburgerItem();
            this.hamburgerItem1 = new MP3_Tag_Editor.HamburgerItem();
            this.statusBar1 = new MP3_Tag_Editor.StatusBar();
            this.customButton1 = new MP3_Tag_Editor.CustomButton();
            this.mylibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            this.infopanel.SuspendLayout();
            this.hamburgerMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // mylibrary
            // 
            this.mylibrary.Controls.Add(this.label2);
            this.mylibrary.Controls.Add(this.customButton1);
            this.mylibrary.Controls.Add(this.dataGridView1);
            this.mylibrary.Controls.Add(this.comboBox1);
            this.mylibrary.Controls.Add(this.label1);
            this.mylibrary.Location = new System.Drawing.Point(321, 193);
            this.mylibrary.Name = "mylibrary";
            this.mylibrary.Size = new System.Drawing.Size(670, 475);
            this.mylibrary.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(86, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Προσθέστε βιβλιοθήκες για την εμφάνιση των τραγουδιών σας!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn,
            this.TitleColumn,
            this.Column1,
            this.ArtistColumn,
            this.Album,
            this.Kind,
            this.Year});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.dataGridView1.Location = new System.Drawing.Point(20, 49);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 408);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.HeaderText = "Όνομα αρχείου";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            this.FileNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FileNameColumn.Width = 120;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Τίτλος";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Αρ. Κομ.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 80;
            // 
            // ArtistColumn
            // 
            this.ArtistColumn.HeaderText = "Καλλιτέχνης";
            this.ArtistColumn.Name = "ArtistColumn";
            this.ArtistColumn.ReadOnly = true;
            this.ArtistColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArtistColumn.Width = 101;
            // 
            // Album
            // 
            this.Album.HeaderText = "Άλμπουμ";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Album.Width = 85;
            // 
            // Kind
            // 
            this.Kind.HeaderText = "Είδος";
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            this.Kind.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Kind.Width = 70;
            // 
            // Year
            // 
            this.Year.HeaderText = "Έτος";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Year.Width = 70;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Επιλέξτε κατάλογο--"});
            this.comboBox1.Location = new System.Drawing.Point(140, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Τρέχων κατάλογος:";
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.SystemColors.Control;
            this.separator.Location = new System.Drawing.Point(324, 161);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(670, 1);
            this.separator.TabIndex = 4;
            this.separator.TabStop = false;
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.CurrentCategoryInfo);
            this.infopanel.Controls.Add(this.CurrentCategory);
            this.infopanel.Location = new System.Drawing.Point(321, 36);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(670, 119);
            this.infopanel.TabIndex = 6;
            // 
            // CurrentCategoryInfo
            // 
            this.CurrentCategoryInfo.AutoSize = true;
            this.CurrentCategoryInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentCategoryInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentCategoryInfo.Location = new System.Drawing.Point(0, 62);
            this.CurrentCategoryInfo.Name = "CurrentCategoryInfo";
            this.CurrentCategoryInfo.Size = new System.Drawing.Size(670, 44);
            this.CurrentCategoryInfo.TabIndex = 5;
            this.CurrentCategoryInfo.Text = "Εδώ εμφανίζονται όλα τα κομμάτια που έχετε προσθέσει στην βιβλιοθήκη\r\nμουσικής σα" +
    "ς!";
            // 
            // CurrentCategory
            // 
            this.CurrentCategory.AutoSize = true;
            this.CurrentCategory.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentCategory.Location = new System.Drawing.Point(-4, 13);
            this.CurrentCategory.Name = "CurrentCategory";
            this.CurrentCategory.Size = new System.Drawing.Size(326, 44);
            this.CurrentCategory.TabIndex = 4;
            this.CurrentCategory.Text = "Η Βιβλιοθήκη μου";
            // 
            // hamburgerMenu1
            // 
            this.hamburgerMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.hamburgerMenu1.Controls.Add(this.searchButton1);
            this.hamburgerMenu1.Controls.Add(this.searchBar1);
            this.hamburgerMenu1.Controls.Add(this.hamburgerItem3);
            this.hamburgerMenu1.Controls.Add(this.hamburgerItem2);
            this.hamburgerMenu1.Controls.Add(this.hamburgerItem1);
            this.hamburgerMenu1.Location = new System.Drawing.Point(2, 25);
            this.hamburgerMenu1.Name = "hamburgerMenu1";
            this.hamburgerMenu1.Size = new System.Drawing.Size(283, 654);
            this.hamburgerMenu1.TabIndex = 1;
            // 
            // searchButton1
            // 
            this.searchButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.searchButton1.Image = ((System.Drawing.Image)(resources.GetObject("searchButton1.Image")));
            this.searchButton1.Location = new System.Drawing.Point(242, 64);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(17, 18);
            this.searchButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton1.TabIndex = 5;
            this.searchButton1.TabStop = false;
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.searchBar1.Location = new System.Drawing.Point(11, 55);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.SearchBoxVisible = true;
            this.searchBar1.Size = new System.Drawing.Size(258, 36);
            this.searchBar1.TabIndex = 4;
            // 
            // hamburgerItem3
            // 
            this.hamburgerItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.hamburgerItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburgerItem3.HamburgerItemImage = global::MP3_Tag_Editor.Properties.Resources.playlist_add_grey_192x19211;
            this.hamburgerItem3.HamburgerItemText = "Λίστες Αναπαραγωγής";
            this.hamburgerItem3.HamburgerToolTip = null;
            this.hamburgerItem3.IsFirstItem = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.hamburgerItem3.Location = new System.Drawing.Point(0, 185);
            this.hamburgerItem3.Name = "hamburgerItem3";
            this.hamburgerItem3.Size = new System.Drawing.Size(283, 35);
            this.hamburgerItem3.TabIndex = 3;
            this.hamburgerItem3.Click += new System.EventHandler(this.hamburgerItem3_Click);
            // 
            // hamburgerItem2
            // 
            this.hamburgerItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.hamburgerItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburgerItem2.HamburgerItemImage = global::MP3_Tag_Editor.Properties.Resources.ItemRecent2;
            this.hamburgerItem2.HamburgerItemText = "Πρόσφατα τραγούδια";
            this.hamburgerItem2.HamburgerToolTip = "Εμφάνιση των τραγουδιών που επεξεργαστήκατε πρόσφατα";
            this.hamburgerItem2.IsFirstItem = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.hamburgerItem2.Location = new System.Drawing.Point(1, 151);
            this.hamburgerItem2.Name = "hamburgerItem2";
            this.hamburgerItem2.Size = new System.Drawing.Size(283, 35);
            this.hamburgerItem2.TabIndex = 2;
            this.hamburgerItem2.Click += new System.EventHandler(this.hamburgerItem2_Click);
            // 
            // hamburgerItem1
            // 
            this.hamburgerItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.hamburgerItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburgerItem1.HamburgerItemImage = global::MP3_Tag_Editor.Properties.Resources.Folder_Music_icon;
            this.hamburgerItem1.HamburgerItemText = "Η Βιβλιοθήκη μου";
            this.hamburgerItem1.HamburgerToolTip = "Όλη η μουσική σας, ομαδοποιημένη κατά καλλιτέχνη, άλμπουμ ή τραγούδι  ";
            this.hamburgerItem1.IsFirstItem = System.Drawing.Color.White;
            this.hamburgerItem1.Location = new System.Drawing.Point(1, 117);
            this.hamburgerItem1.Name = "hamburgerItem1";
            this.hamburgerItem1.Size = new System.Drawing.Size(283, 35);
            this.hamburgerItem1.TabIndex = 1;
            this.hamburgerItem1.Click += new System.EventHandler(this.hamburgerItem1_Click);
            // 
            // statusBar1
            // 
            this.statusBar1._ApplicationName = "MP3 Tag Editor";
            this.statusBar1._Icon = global::MP3_Tag_Editor.Properties.Resources.Icon;
            this.statusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(134)))), ((int)(((byte)(196)))));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar1.Location = new System.Drawing.Point(0, 0);
            this.statusBar1.LocationExit = 1000;
            this.statusBar1.LocationMin = 978;
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(1024, 25);
            this.statusBar1.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.customButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customButton1.CustomButtonText = "Επεξεργασία επιλεγμένων";
            this.customButton1.Location = new System.Drawing.Point(345, 11);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(152, 20);
            this.customButton1.TabIndex = 3;
            this.customButton1.TabStop = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.hamburgerMenu1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.mylibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Tag Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.mylibrary.ResumeLayout(false);
            this.mylibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.hamburgerMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StatusBar statusBar1;
        private HamburgerMenu hamburgerMenu1;
        private HamburgerItem hamburgerItem1;
        private HamburgerItem hamburgerItem2;
        private HamburgerItem hamburgerItem3;
        private SearchBar searchBar1;
        private SearchButton searchButton1;
        private System.Windows.Forms.PictureBox separator;
        private System.Windows.Forms.Panel mylibrary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private CustomButton customButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Label CurrentCategoryInfo;
        private System.Windows.Forms.Label CurrentCategory;
    }
}

