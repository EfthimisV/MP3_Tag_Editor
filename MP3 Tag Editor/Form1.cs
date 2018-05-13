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
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace MP3_Tag_Editor
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        /// <summary>
        ///    Adds a row to the recentdatagriview.
        /// </summary>
        public void AddRows(string filename, string title, string trackno, string artist, string album, string genre, string year)
        {
            recentdatagridview.Rows.Add(filename, title, trackno, artist, album, genre, year);
        }
        /// <summary>
        ///    Replaces a recentdatagriview row with a specific index.
        /// </summary>
        public void ReplaceRow(int rowno, string filename, string title, string trackno, string artist, string album, string genre, string year)
        {
            recentdatagridview.Rows[rowno].Cells[0].Value = filename;
            recentdatagridview.Rows[rowno].Cells[1].Value = title;
            recentdatagridview.Rows[rowno].Cells[2].Value = trackno;
            recentdatagridview.Rows[rowno].Cells[3].Value = artist;
            recentdatagridview.Rows[rowno].Cells[4].Value = album;
            recentdatagridview.Rows[rowno].Cells[5].Value = genre;
            recentdatagridview.Rows[rowno].Cells[6].Value = year;
        }
        /// <summary>
        ///    Sets the recentdatagridview visible property.
        /// </summary>
        public bool RecentDataGridViewVisible
        {
            get
            {
                return recentdatagridview.Visible;
            }
            set
            {
                recentdatagridview.Visible = value;
            }
        }
        /// <summary>
        ///    Sets the label3 visible property.
        /// </summary>
        public bool Label3Visible
        {
            get
            {
                return label3.Visible;
            }
            set
            {
                label3.Visible = value;
            }
        }
        /// <summary>
        ///    The maximum number of rows in the recentdatagridview.
        /// </summary>
        public int MaxNumberOfRows = 20; //Μέγιστος αριθμός γραμμών στη λίστα με τα πρόσφατα τραγούδια
        /// <summary>
        ///    The current number of rows in the recentdatagridview.
        /// </summary>
        public int CurrentNumberOfRows = 0; //Τρέχων αριθμός γραμμών που έχουν προστεθεί στη λίστα με τα πρόσφατα τραγούδια
        /// <summary>
        ///    The number of rows that has to be replaced in the recentdatagridview.
        /// </summary>
        public int RowToBeReplaced { get; set; } = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = hamburgerMenu1; //Θέτω το hamburgerMenu1 ActiveControl property του Form1 
            foreach(Control control in Controls)//Προσθέτω στους event handlers κάθε control όταν γίνεται κλικ να χάνουν το focus τους θέτοντάς το με null
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
            recentpanel.Visible = false;
            songinfo.Visible = (dataGridView1.SelectedRows.Count != 0);
        }

        private void hamburgerItem2_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Πρόσφατα τραγούδια";
            CurrentCategoryInfo.Text = "Τα τραγούδια που πρόσφατα έχετε επεξεργαστεί και αναπαράγει";
            separator.Location = new Point(324, 134);
            infopanel.Size = new Size(670, 92);
            mylibrary.Visible = false;
            recentpanel.Visible = true;
            songinfo.Visible = (recentdatagridview.SelectedRows.Count != 0);
        }

        private void hamburgerItem3_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Λίστες αναπαραγωγής";
            CurrentCategoryInfo.Text = "Δημιουργία λίστας αναπαραγωγής από κομμάτια της βιβλιοθήκης σας";
            separator.Location = new Point(324, 134);
            infopanel.Size = new Size(670, 92);
            mylibrary.Visible = false;
            recentpanel.Visible = false;
            songinfo.Visible = false;
        }
        protected List<string> libraries = new List<string>();
        
        private void customButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0) //Αν έχουν φορτωθεί στοιχεία
            {
                var form1 = new EditingWindow(); //Δημιουργία αντικειμένου editingwindow
                form1.Show(); //Εμφάνιση του αντικειμένου
                form1.ActiveControl = null; //Το activecontrol είναι κενό ώστε να μην έχει focus κάποιο textbox
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    var Song = TagLib.File.Create(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());// Δημιουργία taglib.file με βάση την διαδρομή που βρίσκεται στην πρώτη στήλη
                    //Εισαγωγή τιμών στο αντικείμενο editingwindow
                    form1.TitleText = Song.Tag.Title;
                    form1.ArtistText = Song.Tag.Performers[0];
                    form1.AlbumText = Song.Tag.Album;
                    form1.YearText = Song.Tag.Year.ToString();
                    form1.TrackText = Song.Tag.Track.ToString();
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
                    form1.GenreText = genretexts;
                    form1.CommentText = Song.Tag.Comment;
                    form1.Filepath = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    if (Song.Tag.Pictures.Length >= 1)
                    {
                        var bin = Song.Tag.Pictures[0].Data.Data;
                        form1.AlbumPicture = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);
                    }
                    form1.LyricsText = Song.Tag.Lyrics;
                    if (Song.Tag.AlbumArtists.Length != 0)
                    {
                        form1.AlbumArtist = Song.Tag.AlbumArtists[0];
                    }
                    form1.BeatsPerMinute = Song.Tag.BeatsPerMinute.ToString();
                    if (Song.Tag.Composers.Length != 0)
                    {
                        form1.Composers = Song.Tag.Composers[0];
                    }
                    form1.Conductors = Song.Tag.Conductor;
                    form1.ArtistUrl = Song.Tag.ArtistURL;
                    form1.Copyrights = Song.Tag.Copyright;
                    form1.Description = Song.Tag.Description;
                    form1.Discnumber = Song.Tag.Disc.ToString();
                    form1.Grouping = Song.Tag.Grouping;
                    form1.Subtitle = Song.Tag.Subtitle;
                    form1.Publisher = Song.Tag.Publisher;
                    form1.Lyricist = Song.Tag.Lyricist;
                }
                else
                {
                    List<string> FilePaths = new List<string>(); //Δημιουργία λίστας για την αποθήκευση των διαδρομών των τραγουδιών
                    foreach (DataGridViewRow dtvrow in dataGridView1.SelectedRows)
                    {
                        FilePaths.Add(dtvrow.Cells[0].Value.ToString());//Προσθήκη κάθε διαδρομής τραγουδιού που έχει επιλεχθεί σην λίστα 
                    }
                    string[] SongPaths = FilePaths.ToArray(); //Δημιουργία string array για την αποθήκευση των διαδρομών
                    form1.FilePaths = SongPaths; //Θέτω την ιδιότητα filepaths του EditingWindow με το SongPaths 
                    form1.TitleText = "<Διατήρηση τιμής>";
                    form1.TrackText = "<Διατήρηση τιμής>";
                    form1.LyricsText = "<Διατήρηση τιμής>";
                    form1.BeatsPerMinute = "<Διατήρηση τιμής>";
                    form1.Discnumber = "<Διατήρηση τιμής>";
                    form1.CommentText = "<Διατήρηση τιμής>";
                    List<TagLib.File> songs = new List<TagLib.File>(); //Δημιουργία λίστας για την αποθήκευση των τραγουδιών που έχουν επιλεχθεί με τα tags τους 
                    foreach (string path in SongPaths)
                    {
                        songs.Add(TagLib.File.Create(path)); //Προσθήκη των τραγουδιών στη λίστα
                    }
                    var same_album = true; 
                    for (int i = 1; i < songs.Count && same_album; i++)
                    {
                        if (songs[i - 1].Tag.Album != songs[i].Tag.Album)
                        {
                            same_album = false;
                        }
                    }
                    if (same_album)
                    {
                        form1.ArtistText = songs[0].Tag.Performers[0];
                        form1.AlbumText = songs[0].Tag.Album;
                        form1.YearText = songs[0].Tag.Year.ToString();
                        if (SameGenre(songs))
                        {
                            string genretexts = null;
                            for (int i = 0; i < songs[0].Tag.Genres.Length; i++)
                            {
                                if (i != songs[0].Tag.Genres.Length - 1)
                                {
                                    genretexts = genretexts + songs[0].Tag.Genres[i] + ",";
                                }
                                else
                                {
                                    genretexts = genretexts + songs[0].Tag.Genres[i];
                                }
                            }
                            form1.GenreText = genretexts;
                        }
                        else
                        {
                            form1.GenreText = "<Διατήρηση τιμής>";
                        }
                        if (SameAlbumArtist(songs))
                        {
                                string albumartists = null;
                                for (int i = 0; i < songs[0].Tag.AlbumArtists.Length; i++)
                                {
                                    if (i != songs[0].Tag.AlbumArtists.Length - 1)
                                    {
                                        albumartists = albumartists + songs[0].Tag.AlbumArtists[i] + ",";
                                    }
                                    else
                                    {
                                        albumartists = albumartists + songs[0].Tag.AlbumArtists[i];
                                    }
                                }
                                form1.AlbumArtist = albumartists;
                        }
                        else
                        {
                            form1.AlbumArtist = "<Διατήρηση τιμής>";
                        }
                        if (SameComposers(songs))
                        {
                                string composers = null;
                                for (int i = 0; i < songs[0].Tag.Composers.Length; i++)
                                {
                                    if (i != songs[0].Tag.Composers.Length - 1)
                                    {
                                        composers = composers + songs[0].Tag.Composers[i] + ",";
                                    }
                                    else
                                    {
                                        composers = composers + songs[0].Tag.Composers[i];
                                    }
                                }
                                form1.Composers = composers;
                        }
                        else
                        {
                            form1.Composers = "<Διατήρηση τιμής>";
                        }
                        if (SameConductor(songs))
                        {
                            form1.Conductors = songs[0].Tag.Conductor;
                        }
                        else
                        {
                            form1.Conductors = "<Διατήρηση τιμής>";
                        }
                        if (SameArtistURL(songs))
                        {
                           form1.ArtistUrl = songs[0].Tag.ArtistURL;
                        }
                        else
                        {
                            form1.ArtistUrl = "<Διατήρηση τιμής>";
                        }
                        if (SameCopyrights(songs))
                        {
                            form1.Copyrights = songs[0].Tag.Copyright;
                        }
                        else
                        {
                            form1.Copyrights = "<Διατήρηση τιμής>";
                        }
                        if (SameDescription(songs))
                        {
                            form1.Description = songs[0].Tag.Description;
                        }
                        else
                        {
                            form1.Description = "<Διατήρηση τιμής>";
                        }
                        if (SameGrouping(songs))
                        {
                            form1.Grouping = songs[0].Tag.Grouping;
                        }
                        else
                        {
                            form1.Grouping = "<Διατήρηση τιμής>";
                        }
                        if (SameSubtitle(songs))
                        {
                            form1.Subtitle = songs[0].Tag.Subtitle;
                        }
                        else
                        {
                            form1.Subtitle = "<Διατήρηση τιμής>";
                        }
                        if (SamePublisher(songs))
                        {
                            form1.Publisher = songs[0].Tag.Publisher;
                        }
                        else
                        {
                            form1.Publisher = "<Διατήρηση τιμής>";
                        }
                        if (SameLyricist(songs))
                        {
                            form1.Lyricist = songs[0].Tag.Lyricist;
                        }
                        else
                        {
                            form1.Lyricist = "<Διατήρηση τιμής>";
                        }
                        if (songs[0].Tag.Pictures.Length >= 1)
                        {
                            var bin = songs[0].Tag.Pictures[0].Data.Data;
                            form1.AlbumPicture = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);
                        }
                    }
                    else
                    {
                        form1.AlbumText = "<Διατήρηση τιμής>";
                        form1.YearText = (SameYear(songs)) ? songs[0].Tag.Year.ToString() : "<Διατήρηση τιμής>";
                        form1.CommentText = (SameComment(songs)) ? songs[0].Tag.Comment : "΄<Διατήρηση τιμής>";
                        if (SameGenre(songs))
                        {
                            string genretexts = null;
                            for (int i = 0; i < songs[0].Tag.Genres.Length; i++)
                            {
                                if (i != songs[0].Tag.Genres.Length - 1)
                                {
                                    genretexts = genretexts + songs[0].Tag.Genres[i] + ",";
                                }
                                else
                                {
                                    genretexts = genretexts + songs[0].Tag.Genres[i];
                                }
                            }
                            form1.GenreText = genretexts;
                        }
                        else
                        {
                            form1.GenreText = "<Διατήρηση τιμής>";
                        }
                        if (SameArtist(songs))
                        {
                            string artisttexts = null;
                            for (int i = 0; i < songs[0].Tag.Performers.Length; i++)
                            {
                                if (i != songs[0].Tag.Performers.Length - 1)
                                {
                                    artisttexts = artisttexts + songs[0].Tag.Performers[i] + ",";
                                }
                                else
                                {
                                    artisttexts = artisttexts + songs[0].Tag.Performers[i];
                                }
                            }
                            form1.ArtistText = artisttexts;
                        }
                        else
                        {
                            form1.ArtistText = "<Διατήρηση τιμής";
                        }
                        if (SameAlbumArtist(songs))
                        {
                            string albumartists = null;
                            for (int i = 0; i < songs[0].Tag.AlbumArtists.Length; i++)
                            {
                                if (i != songs[0].Tag.AlbumArtists.Length - 1)
                                {
                                    albumartists = albumartists + songs[0].Tag.AlbumArtists[i] + ",";
                                }
                                else
                                {
                                    albumartists = albumartists + songs[0].Tag.AlbumArtists[i];
                                }
                            }
                            form1.AlbumArtist = albumartists;
                        }
                        else
                        {
                            form1.AlbumArtist = "<Διατήρηση τιμής>";
                        }
                        if (SameComposers(songs))
                        {
                            string composers = null;
                            for (int i = 0; i < songs[0].Tag.Composers.Length; i++)
                            {
                                if (i != songs[0].Tag.Composers.Length - 1)
                                {
                                    composers = composers + songs[0].Tag.Composers[i] + ",";
                                }
                                else
                                {
                                    composers = composers + songs[0].Tag.Composers[i];
                                }
                            }
                            form1.Composers = composers;
                        }
                        else
                        {
                            form1.Composers = "<Διατήρηση τιμής>";
                        }
                        if (SameConductor(songs))
                        {
                            form1.Conductors = songs[0].Tag.Conductor;
                        }
                        else
                        {
                            form1.Conductors = "<Διατήρηση τιμής>";
                        }
                        if (SameArtistURL(songs))
                        {
                            form1.ArtistUrl = songs[0].Tag.ArtistURL;
                        }
                        else
                        {
                            form1.ArtistUrl = "<Διατήρηση τιμής>";
                        }
                        if (SameCopyrights(songs))
                        {
                            form1.Copyrights = songs[0].Tag.Copyright;
                        }
                        else
                        {
                            form1.Copyrights = "<Διατήρηση τιμής>";
                        }
                        if (SameDescription(songs))
                        {
                            form1.Description = songs[0].Tag.Description;
                        }
                        else
                        {
                            form1.Description = "<Διατήρηση τιμής>";
                        }
                        if (SameGrouping(songs))
                        {
                            form1.Grouping = songs[0].Tag.Grouping;
                        }
                        else
                        {
                            form1.Grouping = "<Διατήρηση τιμής>";
                        }
                        if (SameSubtitle(songs))
                        {
                            form1.Subtitle = songs[0].Tag.Subtitle;
                        }
                        else
                        {
                            form1.Subtitle = "<Διατήρηση τιμής>";
                        }
                        if (SamePublisher(songs))
                        {
                            form1.Publisher = songs[0].Tag.Publisher;
                        }
                        else
                        {
                            form1.Publisher = "<Διατήρηση τιμής>";
                        }
                        if (SameLyricist(songs))
                        {
                            form1.Lyricist = songs[0].Tag.Lyricist;
                        }
                        else
                        {
                            form1.Lyricist = "<Διατήρηση τιμής>";
                        }
                    }
                }
            }
        }
        /// <summary>
        ///    Checks if the subtitle of the selected songs are the same.
        /// </summary>
        private bool SameSubtitle(List<TagLib.File> songs)
        {
            var same_subtitle = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Subtitle != songs[i].Tag.Subtitle)
                {
                    same_subtitle = false;
                }
            }
            return same_subtitle;
        }
        /// <summary>
        ///    Checks if the publisher of the selected songs are the same.
        /// </summary>
        private bool SamePublisher(List<TagLib.File> songs)
        {
            var same_publisher = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Publisher != songs[i].Tag.Publisher)
                {
                    same_publisher = false;
                }
            }
            return same_publisher;
        }
        /// <summary>
        ///    Checks if the lyricist of the selected songs are the same.
        /// </summary>
        private bool SameLyricist(List<TagLib.File> songs)
        {
            var same_lyricist = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Lyricist != songs[i].Tag.Lyricist)
                {
                    same_lyricist = false;
                }
            }
            return same_lyricist;
        }
        /// <summary>
        ///    Checks if the grouping of the selected songs are the same.
        /// </summary>
        private bool SameGrouping(List<TagLib.File> songs)
        {
            var same_grouping = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Grouping != songs[i].Tag.Grouping)
                {
                    same_grouping = false;
                }
            }
            return same_grouping;
        }
        /// <summary>
        ///    Checks if the copyright of the selected songs are the same.
        /// </summary>
        private bool SameCopyrights(List<TagLib.File> songs)
        {
            var same_copyrights = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Copyright != songs[i].Tag.Copyright)
                {
                    same_copyrights = false;
                }
            }
            return same_copyrights;
        }
        /// <summary>
        ///    Checks if the description of the selected songs are the same.
        /// </summary>
        private bool SameDescription(List<TagLib.File> songs)
        {
            var same_description = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Description != songs[i].Tag.Description)
                {
                    same_description = false;
                }
            }
            return same_description;
        }
        /// <summary>
        ///    Checks if the artist urls of the selected songs are the same.
        /// </summary>
        private bool SameArtistURL(List<TagLib.File> songs)
        {
            var same_url = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.ArtistURL != songs[i].Tag.ArtistURL)
                {
                    same_url = false;
                }
            }
            return same_url;
        }
        /// <summary>
        ///    Checks if the conductors of the selected songs are the same.
        /// </summary>
        private bool SameConductor(List<TagLib.File> songs)
        {
            var same_conductor = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Conductor != songs[i].Tag.Conductor)
                {
                    same_conductor = false;
                }
            }
            return same_conductor;
        }
        /// <summary>
        ///    Checks if the composers of the selected songs are the same.
        /// </summary>
        private bool SameComposers(List<TagLib.File> songs)
        {
            var same_composers = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Composers.Length != songs[i].Tag.Composers.Length)
                {
                    same_composers = false;
                }
                else
                {
                    for (int k = 0; k < songs[i - 1].Tag.Composers.Length; k++)
                    {
                        if (songs[i - 1].Tag.Composers[k].Trim() != songs[i].Tag.Composers[k].Trim())
                        {
                            same_composers = false;
                        }
                    }
                }
            }
            return same_composers;
        }
        /// <summary>
        ///    Checks if the album artists of the selected songs are the same.
        /// </summary>
        private bool SameAlbumArtist(List<TagLib.File> songs)
        {
            var same_album_artist = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.AlbumArtists.Length != songs[i].Tag.AlbumArtists.Length)
                {
                    same_album_artist = false;
                }
                else
                {
                    for (int k = 0; k < songs[i - 1].Tag.AlbumArtists.Length; k++)
                    {
                        if (songs[i - 1].Tag.AlbumArtists[k].Trim() != songs[i].Tag.AlbumArtists[k].Trim())
                        {
                            same_album_artist = false;
                        }
                    }
                }
            }
            return same_album_artist;
        }
        /// <summary>
        ///    Checks if the comments of the selected songs are the same.
        /// </summary>
        private bool SameComment(List<TagLib.File> songs)
        {
            var same_comment = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Comment != songs[i].Tag.Comment)
                {
                    same_comment = false;
                }
            }
            return same_comment;
        }
        /// <summary>
        ///    Checks if the release years of the selected songs are the same.
        /// </summary>
        private bool SameYear(List<TagLib.File> songs)
        {
            var same_year = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Year != songs[i].Tag.Year)
                {
                    same_year = false;
                }
            }
            return same_year;
        }
        /// <summary>
        ///    Checks if the artists of the selected songs are the same.
        /// </summary>
        private bool SameArtist(List<TagLib.File> songs)
        {
            var same_artist = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Performers.Length != songs[i].Tag.Performers.Length)
                {
                    same_artist = false;
                }
                else
                {
                    for (int k = 0; k < songs[i - 1].Tag.Performers.Length; k++)
                    {
                        if (songs[i - 1].Tag.Performers[k].Trim() != songs[i].Tag.Performers[k].Trim())
                        {
                            same_artist = false;
                        }
                    }
                }
            }
            return same_artist;
        }
        /// <summary>
        ///    Checks if the genres of the selected songs are the same.
        /// </summary>
        private bool SameGenre(List<TagLib.File> songs)
        {
            var same_genre = true;
            for (int i = 1; i < songs.Count; i++)
            {
                if (songs[i - 1].Tag.Genres.Length != songs[i].Tag.Genres.Length)
                {
                    same_genre = false;
                }
                else
                {
                    for (int k = 0; k < songs[i - 1].Tag.Genres.Length; k++)
                    {
                        if (songs[i - 1].Tag.Genres[k].Trim() != songs[i].Tag.Genres[k].Trim())
                        {
                            same_genre = false;
                        }
                    }
                }
            }
            return same_genre;
        }
        /// <summary>
        ///    Adds the items to the selected DataGridView.
        /// </summary>
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
            dataGridView1.Visible = (dataGridView1.RowCount != 0); //Το datagridview1 φαίνεται μόνο αν έχουν φορτωθεί στοιχεία
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

        private void customButton3_Click(object sender, EventArgs e)
        {
            recentdatagridview.Rows.Clear();
            RowToBeReplaced = 0;
            CurrentNumberOfRows = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                TagLib.File Song = TagLib.File.Create(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (Song.Tag.Pictures.Length >= 1)
                {
                    var bin = Song.Tag.Pictures[0].Data.Data;
                    albumart.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);
                }
                songtitle.Text = "Τίτλος: " + Song.Tag.Title;
                albumtitle.Text = "Άλμπουμ: " + Song.Tag.Album;
                artistname.Text = "Καλλιτέχνης: " + Song.Tag.Performers[0];
                yearlabel.Text = "Έτος: " + Song.Tag.Year.ToString();
                songduration.Text = "Διάρκεια: " + Song.Properties.Duration.ToString().Substring(0, Song.Properties.Duration.ToString().LastIndexOf("."));
                genre.Text = "Είδος: " + Song.Tag.Genres[0];
                tagsversion.Text = "Ετικέτες: " + Song.TagTypes.ToString();
                songinfo.Visible = true;
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                }
                if (!roundedButton1.IsPlayImage)
                {
                    roundedButton1.Image = roundedButton1.ImagePlayStandard;
                    roundedButton1.IsPlayImage = true;
                }
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                outputDevice.Init(audioFile);
            }
            if (roundedButton1.IsPlayImage)
            {
                outputDevice.Play();
            }
            else
            {
                outputDevice.Pause();
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

       
    }
}
