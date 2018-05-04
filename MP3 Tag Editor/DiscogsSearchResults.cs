using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Tag_Editor
{
    public partial class DiscogsSearchResults : Form
    {
        public string Images
        {
            set
            {
                if (albumart1.ImageLocation == null)
                {
                    albumart1.ImageLocation = value;
                }
                else if (albumart2.ImageLocation == null)
                {
                    albumart2.ImageLocation = value;
                }
                else if (albumart3.ImageLocation == null)
                {
                    albumart3.ImageLocation = value;
                }
                else if (albumart4.ImageLocation == null)
                {
                    albumart4.ImageLocation = value;
                }
                else if (albumart5.ImageLocation == null)
                {
                    albumart5.ImageLocation = value;
                }
                else if (albumart6.ImageLocation == null)
                {
                    albumart6.ImageLocation = value;
                }
                else if (albumart7.ImageLocation == null)
                {
                    albumart7.ImageLocation = value;
                }
                else
                {
                    albumart8.ImageLocation = value;
                }
            }
        }
        public string[] images
        {
            set
            {

            }
        }
        public DiscogsSearchResults()
        {
            InitializeComponent();
        }

        private void DiscogsSearchResults_Load(object sender, EventArgs e)
        {
            FormCollection formCollection = Application.OpenForms;
            List<PictureBox> albumarts = new List<PictureBox>();
            var EditingWindowInstance = new EditingWindow();
            foreach (Form form in formCollection)
            {
                if (form is EditingWindow)
                {
                    EditingWindowInstance = (EditingWindow) form;
                }
            }
            foreach (Control albumart in Controls)
            {
                if (albumart is PictureBox)
                {
                    albumarts.Add((PictureBox)albumart);
                }
            }
            foreach (PictureBox albumart in albumarts)
            {
                albumart.Click += (sender1, e1) =>
                {
                    EditingWindowInstance.downloaderalbumartpath = albumart.ImageLocation;
                    EditingWindowInstance.ActiveControl = EditingWindowInstance.Controls[0];
                    Close();
                };
            }
        }
    }
}
