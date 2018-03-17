using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace MP3_Tag_Editor
{
   
    public class ExitButton : PictureBox
    {
        /// <summary> Δημιουργία του κομπιού για το κλείσιμο του παραθύρου </summary>
        public ToolTip toolTip = new ToolTip();
        public Form InstanceForm
        {
            get
            {
                return FindForm();
            }
        }
        public ExitButton()
        {
            Size = new Size(23, 25);
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = Properties.Resources.CloseButtonStandard;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Image = Properties.Resources.CloseButtonPress;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Image = Properties.Resources.CloseButtonOn;
            toolTip.SetToolTip(this, "Έξοδος");
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Image = Properties.Resources.CloseButtonStandard;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Image = Properties.Resources.CloseButtonOn;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            InstanceForm.Close();
        }
    }
    public class MinimizeButton : PictureBox
    {
        public ToolTip toolTip = new ToolTip();
        public Form InstanceForm
        {
            get
            {
                return FindForm();
            }
        }
        public MinimizeButton()
        {
            Size = new Size(23, 25);
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = Properties.Resources.MinimizeButtonStandard;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Image = Properties.Resources.MinimizeButtonPress;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Image = Properties.Resources.MinimizeButtonOn;
            toolTip.SetToolTip(this, "Ελαχιστοποίηση");
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Image = Properties.Resources.MinimizeButtonStandard;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Image = Properties.Resources.MinimizeButtonOn;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            InstanceForm.WindowState = FormWindowState.Minimized;
        }
    }
    public class StatusBar : Panel
    {
        private int mousex, mousey;
        private bool drag;

        public Label ApplicationName = new Label();
        public PictureBox Icon = new PictureBox();
        public MinimizeButton MinButton = new MinimizeButton();
        public ExitButton CloseButton = new ExitButton();
        
        [Description("The text associated with the control."), Category("Appearance")]
        public string _ApplicationName
        {
            get
            {
                return ApplicationName.Text;
            }
            set
            {
                ApplicationName.Text = value;
            }
        }
        [Description("Indicated the Icon for the form."), Category("Appearance")]
        public Image _Icon
        {
            get
            {
                return Icon.Image;
            }
            set
            {
                Icon.Image = value;
            }
        }
        public Form Instance
        {
            get
            {
                return FindForm();
            }
        }
        
        public StatusBar()
        {
            Dock = DockStyle.Top;
            Height = 25;
            BackColor = Color.FromArgb(11, 134, 196);
            ApplicationName.AutoSize = true;
            ApplicationName.ForeColor = Color.White;
            ApplicationName.Font = new Font("Century Gothic", 10);
            ApplicationName.Location = new Point(35, 2);
            Icon.Size = new Size(18, 18);
            Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            Icon.Location = new Point(10, 3);
            MinButton.Location = new Point(978, 0);
            CloseButton.Location = new Point(1000, 0);
            Controls.Add(ApplicationName);
            Controls.Add(Icon);
            Controls.Add(MinButton);
            Controls.Add(CloseButton);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            drag = true;
            mousex = Cursor.Position.X - Instance.Left;
            mousey = Cursor.Position.Y - Instance.Top;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (drag)
            {
                Instance.Top = Cursor.Position.Y - mousey;
                Instance.Left = Cursor.Position.X - mousex;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            drag = false;
        }
    }
    public class HamburgerMenu : Panel
    {
        public HamburgerMenu()
        {
            Dock = DockStyle.Left;
        }
    }
}