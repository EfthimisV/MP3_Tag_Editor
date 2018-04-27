using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace MP3_Tag_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = hamburgerMenu1;
            foreach(Control control in Controls)
            {
                control.Click += (sender1, e1) =>
                {
                    ActiveControl = null;
                };
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(11,134,196), 3), DisplayRectangle); //Για το σχεδιασμό του μπλε πλαισίου γύρω από το παράθυρο
        }

        private void hamburgerItem1_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Η Βιβλιοθήκη μου";
            CurrentCategoryInfo.Text = "Εδώ εμφανίζονται όλα τα κομμάτια που έχετε προσθέσει στην βιβλιοθήκη\nμουσικής σας!";
            separator.Location = new Point(324, 161);
            infopanel.Size = new Size(670, 119);
            mylibrary.Visible = true;
           
        }

        private void hamburgerItem2_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Πρόσφατα τραγούδια";
            CurrentCategoryInfo.Text = "Τα τραγούδια που πρόσφατα έχετε επεξεργαστεί και αναπαράγει";
            separator.Location = new Point(324, 134);
            infopanel.Size = new Size(670, 92);
            mylibrary.Visible = false;
        }

        private void hamburgerItem3_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Λίστες αναπαραγωγής";
            CurrentCategoryInfo.Text = "Δημιουργία λίστας αναπαραγωγής από κομμάτια της βιβλιοθήκης σας";
            separator.Location = new Point(324, 134);
            infopanel.Size = new Size(670, 92);
            mylibrary.Visible = false;
        }
        protected List<string> libraries = new List<string>();
        
        private void customButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0) //Αν έχουν φορτωθεί στοιχεία
            {
                var form1 = new EditingWindow(); //Δημιουργία αντικειμένου editingwindow
                form1.Show(); //Εμφάνιση του αντικειμένου
                form1.ActiveControl = null; //Το activecontrol είναι κενό ώστε να μην έχει focus κάποιο textbox
                var Song = TagLib.File.Create(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());// Δημιουργία taglib.file με βάση την διαδρομή που βρίσκεται στην πρώτη στήλη
                //Εισαγωγή τιμών στο αντικείμενο editingwindow
                form1.titletext = Song.Tag.Title; 
                form1.artisttext = Song.Tag.Performers[0];
                form1.albumtext = Song.Tag.Album;
                form1.yeartext = Song.Tag.Year.ToString();
                form1.tracktext = Song.Tag.Track.ToString();
                string genretexts = null;
                for (int i = 0; i < Song.Tag.Genres.Length; i++)
                {
                    if (i != Song.Tag.Genres.Length - 1)
                    {
                        genretexts = genretexts + Song.Tag.Genres[i] + ",";
                    }
                    else
                    {
                        genretexts = genretexts + Song.Tag.Genres[i];
                    }
                }
                form1.genretext = genretexts;
                form1.commentext = Song.Tag.Comment;
                form1.filepath = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (Song.Tag.Pictures.Length >= 1)
                {
                    var bin = Song.Tag.Pictures[0].Data.Data;
                    form1.albumpicture = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);
                }
                form1.LyricsText = Song.Tag.Lyrics;
                if (Song.Tag.AlbumArtists.Length != 0)
                {
                    form1.albumartist = Song.Tag.AlbumArtists[0];
                }
                form1.beatsperminute = Song.Tag.BeatsPerMinute.ToString();
                if (Song.Tag.Composers.Length != 0)
                {
                    form1.composers = Song.Tag.Composers[0];
                }
                form1.conductors = Song.Tag.Conductor;
                form1.artisturl = Song.Tag.ArtistURL;
                form1.copyrights = Song.Tag.Copyright;
                form1.description = Song.Tag.Description;
                form1.discnumber = Song.Tag.Disc.ToString();
                form1.grouping = Song.Tag.Grouping;
                form1.subtitle = Song.Tag.Subtitle;
                form1.publisher = Song.Tag.Publisher;
                form1.lyricist = Song.Tag.Lyricist;
            }
        }
       
        private void additems(string path)
        {
            dataGridView1.Rows.Clear();
            var pathfilenames = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".mp3"));//Φόρτωση των αρχείων που βρίσκονται στην βιβλιοθήκη
            int rowcounter = 0; //Μετρητής για το foreach statement
            foreach (string filename in pathfilenames)
            {
                TagLib.File song = TagLib.File.Create(filename); //Δημιουργία αντικειμένου taglib.file
                dataGridView1.Rows.Add(filename, song.Tag.Title, song.Tag.Track, song.Tag.Performers[0], song.Tag.Album, song.Tag.FirstGenre, song.Tag.Year);//Προσθήκη σειράς στο datagridview1 με τις πληροφορίες του τραγουδιού
                dataGridView1.Rows[rowcounter].Resizable = DataGridViewTriState.False; //Η εκάστοτε γραμμή δεν μπορεί να αλλάξει μέγεθος από τον χρήστη 
                rowcounter++;
            }
            dataGridView1.Rows[0].Selected = (dataGridView1.RowCount != 0);//Αν έχουν φορτωθεί στοιχεία, τότε η πρώτη γραμμή του datagridview1 επιλέγεται
            dataGridView1.Visible = (dataGridView1.RowCount != 0); //Το datagridvie1 φαίνεται μόνο αν έχουν φορτωθεί στοιχεία
            label2.Visible = (dataGridView1.RowCount == 0); // Η ετικέτα φαίνεται μόνο αν δεν έχουν φορτωθεί στοιχεία
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FolderBrowserDialog LibraryBrowser = new FolderBrowserDialog();

            if (comboBox1.Text == "--Επιλέξτε κατάλογο--")
            {
                DialogResult result = LibraryBrowser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    comboBox1.Items.Add(Path.GetFileName(LibraryBrowser.SelectedPath.ToString())); //Προσθήκη της βιβλιοθήκης στο combobox1
                    comboBox1.Text = Path.GetFileName(LibraryBrowser.SelectedPath.ToString()); //Το text property του combobox παίρνει την τιμή του ονόματος της βιβλιοθήκης
                    libraries.Add(LibraryBrowser.SelectedPath); //Προσθήκη της διαδρομής στην λίστα με τις διαδρομές των βιβλιοθηκών
                    additems(LibraryBrowser.SelectedPath);
                }
            }
            else
            {
                var key = comboBox1.Text;
                var index = 0;
                var position = 0;
                bool found = false;
                while (index < libraries.Count && !found)
                {
                    if (libraries[index] == key)
                    {
                        found = true;
                        position = index;
                    }
                    else
                    {
                        index++;
                    }
                }
                additems(libraries[position]);
            }
        }
    }
}
