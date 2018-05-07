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
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace MP3_Tag_Editor
{

    public partial class EditingWindow : Form
    {
        public EditingWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        ///    Prepares the link for searching in the discogs database.
        /// </summary>
        public string SetQueryLink(string consumer_key, string consumer_secret_key, string artist_album)
        {
            artist_album = artist_album.Replace(" ", "+");
            var discogs_link = "https://api.discogs.com/database/search?page=1&per_page=8&key=" + consumer_key + "&secret=" + consumer_secret_key + "&q=" + artist_album;
            return discogs_link;
        }
        /// <summary>
        ///    Gets and sets the text displayed on the titletextbox.
        /// </summary>
        public string TitleText
        {
            get
            {
                return titletextbox.Text;
            }
            set
            {
                titletextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the artisttextbox.
        /// </summary>
        public string ArtistText
        {
            get
            {
                return artisttextbox.Text;
            }
            set
            {
                artisttextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the albumtextbox.
        /// </summary>
        public string AlbumText
        {
            get
            {
                return albumtextbox.Text;
            }
            set
            {
                albumtextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the yeartextbox.
        /// </summary>
        public string YearText
        {
            get
            {
                return yeartextbox.Text;
            }
            set
            {
                yeartextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the tracktextbox.
        /// </summary>
        public string TrackText
        {
            get
            {
                return tracktextbox.Text;
            }
            set
            {
                tracktextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the genretextbox.
        /// </summary>
        public string GenreText
        {
            get
            {
                return genretextbox.Text;
            }
            set
            {
                genretextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the commenttextbox.
        /// </summary>
        public string CommentText
        {
            get
            {
                return commenttextbox.Text;
            }
            set
            {
                commenttextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the cover art displayed on the coverartpicturebox.
        /// </summary>
        public Image AlbumPicture
        {
            get
            {
                return albumart.Image;
            }
            set
            {
                albumart.Image = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the lyricstextbox.
        /// </summary>
        public string LyricsText
        {
            get
            {
                return lyricstextbox.Text;
            }
            set
            {
                lyricstextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the albumartisttextbox.
        /// </summary>
        public string AlbumArtist
        {
            get
            {
                return albumartisttextbox.Text;
            }
            set
            {
                albumartisttextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the beatsperminutetextbox.
        /// </summary>
        public string BeatsPerMinute
        {
            get
            {
                return beatsperminutetextbox.Text;
            }
            set
            {
                beatsperminutetextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the composerstextbox.
        /// </summary>
        public string Composers
        {
            get
            {
                return composerstextbox.Text;
            }
            set
            {
                composerstextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the conductorstextbox.
        /// </summary>
        public string Conductors
        {
            get
            {
                return conductorstextbox.Text;
            }
            set
            {
                conductorstextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the artisturltextbox.
        /// </summary>
        public string ArtistUrl
        {
            get
            {
                return artisturltextbox.Text;
            }
            set
            {
                artisturltextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the copyrightstextbox.
        /// </summary>
        public string Copyrights
        {
            get
            {
                return copyrightstextbox.Text;
            }
            set
            {
                copyrightstextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the descriptiontextbox.
        /// </summary>
        public string Description
        {
            get
            {
                return descriptiontextbox.Text;
            }
            set
            {
                descriptiontextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the discnumbertextbox.
        /// </summary>
        public string Discnumber
        {
            get
            {
                return discnumbertextbox.Text;
            }
            set
            {
                discnumbertextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the groupingtextbox.
        /// </summary>
        public string Grouping
        {
            get
            {
                return groupingtextbox.Text;
            }
            set
            {
                groupingtextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the titletextbox.
        /// </summary>
        public string Subtitle
        {
            get
            {
                return subtitletextbox.Text;
            }
            set
            {
                subtitletextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the publishertextbox.
        /// </summary>
        public string Publisher
        {
            get
            {
                return publishertextbox.Text;
            }
            set
            {
                publishertextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the text displayed on the lyricisttextbox.
        /// </summary>
        public string Lyricist
        {
            get
            {
                return lyricisttextbox.Text; ;
            }
            set
            {
                lyricisttextbox.Text = value;
            }
        }
        /// <summary>
        ///    Gets and sets the path of the song selected in the music library.
        /// </summary>
        public string Filepath { get; set; }
        /// <summary>
        ///    Gets and sets the path of the image selected from the OpenFileDialog.
        /// </summary>
        public string AlbumArtPath { get; set; }
        /// <summary>
        ///    Gets and sets the path of the cover art downloaded from Discogs.
        /// </summary>
        public string DownloaderAlbumArtPath
        {
            get
            {
                return albumart.ImageLocation;
            }
            set
            {
                albumart.ImageLocation = value;
            }
        }
        public string[] _FilePaths;
        /// <summary>
        ///    Gets the paths of mulitple songs selected from the music library.
        /// </summary>
        public string[] FilePaths
        {
            set
            {
                _FilePaths = value;
            }
        }
        private string[] MultipleValuesProcessor(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].TrimEnd();
                values[i] += ' ';
            }
            return values;
        }
        private void EditingWindow_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls) //Προσθέτω στον event handler κάθε κοντρόλ την απομάκρυνση του focus όταν γίνεται κλικ οπουδήποτε στο παράθυρο
            {
                control.Click += (sender1, e1) =>
                {
                    ActiveControl = generalinfo;
                };
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form1 fc = (Form1) Application.OpenForms["Form1"]; //Ανιχνεύω την παρουσία του Form1
            if (_FilePaths == null || _FilePaths.Length == 0) //Αν έχει φορτωθεί μόνο ένα τραγούδι
            {
                TagLib.File Song = TagLib.File.Create(Filepath);//Δημιουργία αντικειμένου TagLib.File από την διαδρομή αρχείου του τραγουδιού
                //Ανάθεση των ετικετών του τραγουδιού μέσω των πεδίων εισόδου του παραθύρου 
                Song.Tag.Title = titletextbox.Text;
                Song.Tag.Album = albumtextbox.Text;
                Song.Tag.Year = Convert.ToUInt32(yeartextbox.Text);
                Song.Tag.Track = Convert.ToUInt32(tracktextbox.Text);
                Song.Tag.Comment = commenttextbox.Text;
                Song.Tag.Genres = MultipleValuesProcessor(genretextbox.Text.Split(',').ToArray());
                Song.Tag.Performers = MultipleValuesProcessor(artisttextbox.Text.Split(',').ToArray());
                //Αν έχει επιλεχθεί τοπικά εικόνα για το άλμπουμ, τότε την αναθέτω στο τραγούδι
                if (AlbumArtPath != null)
                {
                    TagLib.Id3v2.AttachedPictureFrame pic = new TagLib.Id3v2.AttachedPictureFrame();
                    pic.TextEncoding = TagLib.StringType.Latin1;
                    pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                    pic.Type = TagLib.PictureType.FrontCover;
                    pic.Data = TagLib.ByteVector.FromPath(AlbumArtPath);
                    Song.Tag.Pictures = new TagLib.IPicture[1] { pic };
                }
                //Αν έχει ληφθεί online η εικόνα, τότε την αναθέτω στο τραγούδι
                if (DownloaderAlbumArtPath != null)
                {
                    TagLib.Id3v2.AttachedPictureFrame pic = new TagLib.Id3v2.AttachedPictureFrame();
                    pic.TextEncoding = TagLib.StringType.Latin1;
                    pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                    pic.Type = TagLib.PictureType.FrontCover;
                    pic.Data = TagLib.ByteVector.FromPath(DownloaderAlbumArtPath);
                    Song.Tag.Pictures = new TagLib.IPicture[1] { pic };
                }
                Song.Save();
            }
            else
            {
                //Αν έχουν επιλεχθεί πολλά τραγούδια, τότε ακολουθώ την ίδια διαδικασία που ακολουθώ για ένα τραγούδι, για κάθε τραγούδι
                for (int i =0; i< _FilePaths.Length; i++)
                {
                    TagLib.File song = TagLib.File.Create(_FilePaths[i]);
                    if (titletextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Title = titletextbox.Text;
                    }
                    if (artisttextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Performers = MultipleValuesProcessor(artisttextbox.Text.Split(',').ToArray());
                    }
                    if (albumtextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Album = albumtextbox.Text;
                    }
                    if (yeartextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Year = Convert.ToUInt32(yeartextbox.Text);
                    }
                    if (tracktextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Track = Convert.ToUInt32(tracktextbox.Text);
                    }
                    if (genretextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Genres = MultipleValuesProcessor(genretextbox.Text.Split(',').ToArray());
                    }
                    if (commenttextbox.Text != "<Διατήρηση τιμής>")
                    {
                        song.Tag.Comment = commenttextbox.Text;
                    }
                    if (AlbumArtPath != null)
                    {
                        TagLib.Id3v2.AttachedPictureFrame pic = new TagLib.Id3v2.AttachedPictureFrame();
                        pic.TextEncoding = TagLib.StringType.Latin1;
                        pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                        pic.Type = TagLib.PictureType.FrontCover;
                        pic.Data = TagLib.ByteVector.FromPath(AlbumArtPath);
                        song.Tag.Pictures = new TagLib.IPicture[1] { pic };
                    }
                    if (DownloaderAlbumArtPath != null)
                    {
                        TagLib.Id3v2.AttachedPictureFrame pic = new TagLib.Id3v2.AttachedPictureFrame();
                        pic.TextEncoding = TagLib.StringType.Latin1;
                        pic.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                        pic.Type = TagLib.PictureType.FrontCover;
                        pic.Data = TagLib.ByteVector.FromPath(DownloaderAlbumArtPath);
                        song.Tag.Pictures = new TagLib.IPicture[1] { pic };
                    }
                    song.Save();
                }
            }
        }

        private void hamburgerItem1_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Γενικές πληροφορίες";
            CurrentCategoryInfo.Text = "Εδώ μπορείτε να επεξεργαστείτε τις πιο συνηθισμένες ετικέτες των αρχείων\nσας, όπως ο τίτλος, ο καλλιτέχνης κλπ";
            generalinfo.Show();
            complexedit.Hide();
        }

        private void hamburgerItem2_Click(object sender, EventArgs e)
        {
            CurrentCategory.Text = "Σύνθετη επεξεργασία";
            CurrentCategoryInfo.Text = "Εδώ μπορείτε να επεξεργαστείτε τις πιο σύνθετες ετικέτες των αρχείων σας,\n όπως οι στίχοι, ο εκδότης, ο συνθέτης κλπ";
            generalinfo.Hide();
            complexedit.Show();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (_FilePaths == null || _FilePaths.Length == 0)
            {
                TagLib.File Song = TagLib.File.Create(Filepath);
                Song.Tag.Lyrics = lyricstextbox.Text;
                Song.Tag.AlbumArtists = MultipleValuesProcessor(albumartisttextbox.Text.Split(',').ToArray());
                Song.Tag.BeatsPerMinute = Convert.ToUInt32(beatsperminutetextbox.Text);
                Song.Tag.Composers = MultipleValuesProcessor(composerstextbox.Text.Split(',').ToArray());
                Song.Tag.Conductor = conductorstextbox.Text;
                Song.Tag.ArtistURL = artisturltextbox.Text;
                Song.Tag.Copyright = copyrightstextbox.Text;
                Song.Tag.Description = descriptiontextbox.Text;
                Song.Tag.Disc = Convert.ToUInt32(discnumbertextbox.Text);
                Song.Tag.Grouping = groupingtextbox.Text;
                Song.Tag.Subtitle = subtitletextbox.Text;
                Song.Tag.Publisher = publishertextbox.Text;
                Song.Tag.Lyricist = lyricisttextbox.Text;
                Song.Save();
            }
            else
            {

            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            dropdownpanel.Visible = !dropdownpanel.Visible; //Η επιλογή dropdown φαίνεται ή όχι μόνο αν φαίνεται ή όχι
            ActiveControl = dropdownpanel; //Γίνεται activecontrol το dropdown panel για να μη φάινεται όταν χάνει focus
        }

        private void dropdownpanel_Leave(object sender, EventArgs e)
        {
            dropdownpanel.Visible = false;
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog albumart1 = new OpenFileDialog();
            DialogResult result = albumart1.ShowDialog();
            if (result == DialogResult.OK)
            {
                albumart.Image = new Bitmap(albumart1.FileName);
                AlbumArtPath = Path.GetFullPath(albumart1.FileName);
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            DiscogsSearchResults discogsSearchResults = new DiscogsSearchResults();//Προετοιμασία του παραθύρου εμφάνισης αποτελεσμάτων στο Discogs
            WebClient jsondownloader = new WebClient(); //Προετοιμασία του πελάτη για την λήψη του JSON String
            jsondownloader.Headers.Add("User-Agent: MP3_Tag_Editor/0.5 +http://github.com/EfthimisV/MP3_Tag_Editor");//Προσθήκη των κατάλληλων headers για την αποφυγή exceptions
            var json = jsondownloader.DownloadString(SetQueryLink("SaVhpakXCQDKXQPjpWuH", "apFJViSZMNibBlIIlMixPvRsJBcshqkZ", artisttextbox.Text + " " + albumtextbox.Text));//Λήψη του JSON String 
            DiscogsResponse discogsResponse = JsonConvert.DeserializeObject<DiscogsResponse>(json); //Ανάλυσή του μέσω των βοηθητικών κλάσεων
            int resultslength = discogsResponse.results.Length;//Αριθμός των αποτελεσμάτων που έχουν επιστραφεί (μέγιστος αριθμός 8)
            List<string> cover_image_urls = new List<string>(); //Λίστα για την αποθήκευση των links για τα cover images
            for (int i=0; i<resultslength; i++)
            {
                if (!discogsResponse.results[i].cover_image.Contains("spacer.gif")) //Αν περιέχει το spacer.gif σημαίνει ότι δεν μπορεί να ληφθεί
                {
                    cover_image_urls.Add(discogsResponse.results[i].cover_image); //Προσθέτω στην λίστα με τα urls το αντίστοιχο από τα αποτελέσματα
                }
            }
            WebClient covert_art_downloader = new WebClient(); //Προετοιμασία του πελάτη για την λήψη των cover images
            for (int i =0; i <cover_image_urls.Count; i++)
            {
                covert_art_downloader.Headers.Add("User-Agent: MP3_Tag_Editor/0.5 +http://github.com/EfthimisV/MP3_Tag_Editor"); //Προσθήκη των κατάλληλων headers για την λήψη τους
                covert_art_downloader.DownloadFile(cover_image_urls[i], @"C:\Users\Efthimis\Pictures\temp"+ Convert.ToInt32(i+1).ToString() +".jpg");//Λήψη των αρχείων
                discogsSearchResults.Images = @"C:\Users\Efthimis\Pictures\temp" + Convert.ToInt32(i + 1).ToString() + ".jpg";//Εμφάνισή τους στα κατάλληλα albumarttextboxes του DiscogsSearchResults
            }
            discogsSearchResults.Show();//Εμφάνιση του DiscogsSearchResults
        }

        private void discardbutton_Click(object sender, EventArgs e)
        {
            using (TagLib.File song = TagLib.File.Create(Filepath))
            {
                if (song.Tag.Pictures.Length >= 1)
                {
                    var bin = song.Tag.Pictures[0].Data.Data;
                    albumart.Image= Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);
                }
            }
        }
    }
}
