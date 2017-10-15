using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio
{
    public partial class frmInfoBox : UserControl
    {

        public string Titel { get; set; }
        public string Info { get; set; }

        public Bitmap InfoPic { get; set; }

        Action actionTitel = null;
        Action actionInfo = null;
        Action actionPic = null;

        public enum ClickEvents { Titel, Info, Pic}

        /// <summary>
        /// Konstruktor für eine InfoBox mit Titel, Info und einem Pfad zu einer Bilddatei.
        /// </summary>
        /// <param name="titel">Titel</param>
        /// <param name="info">Infotext</param>
        /// <param name="picPath">Pfad zu Bilddatei</param>
        public frmInfoBox(string titel, string info, string picPath)
        {
            InitializeComponent();

            Bitmap pic;

            try
            {
                pic = new Bitmap(picPath);
            }
            catch
            {
                pic = null;
            }

            setSettings(titel, info, pic);

        }

        /// <summary>
        /// Konstruktor für eine InfoBox mit Titel, Info, einem Pfad zu einer Bilddatei sowie Möglichkeit ein Clickevent zu übergeben.
        /// </summary>
        /// <param name="titel">Titel</param>
        /// <param name="info">Infotext</param>
        /// <param name="picPath">Pfad zur Bilddatei</param>
        /// <param name="ac">Methode die ausgeführt werden soll</param>
        /// <param name="evclick">Control das Methode ausführen soll.</param>
        public frmInfoBox(string titel, string info, string picPath, Action ac, ClickEvents evclick)
        {
            InitializeComponent();

            Bitmap pic;

            try
            {
                pic = new Bitmap(picPath);
            }
            catch{ pic = null; }

            setSettings(titel, info, pic);
                      

            switch (evclick)
            {
                case ClickEvents.Info: { actionInfo = ac; rtbInfoText.Cursor = Cursors.Hand; break; }
                case ClickEvents.Pic: { actionPic = ac; pictureBox1.Cursor = Cursors.Hand; break; }
                case ClickEvents.Titel: { actionTitel = ac; lbTitel.Cursor = Cursors.Hand; break; }

            }

        }


        /// <summary>
        /// Konstruktor für eine InfoBox mit Titel, Info und einer Bitmap
        /// </summary>
        /// <param name="titel">Titel</param>
        /// <param name="info">Infotext</param>
        /// <param name="pic">Info Picture</param>
        public frmInfoBox(string titel, string info, Bitmap pic)
        {
            InitializeComponent();

            setSettings(titel, info, pic);

        }

        /// <summary>
        /// Übergibt Settings an Formular
        /// </summary>
        /// <param name="titel">Titel</param>
        /// <param name="info">Infotext</param>
        /// <param name="pic">Info Picture</param>
        private void setSettings(string titel, string info, Bitmap pic)
        {

            Titel = titel;
            Info = info;

            if(pic != null)
                InfoPic = pic; 

        }

        private void frmInfoBox_Load(object sender, EventArgs e)
        {

            rtbInfoText.Text = Info;
            pictureBox1.Image = InfoPic;
            lbTitel.Text = Titel;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (actionPic != null)
                actionPic();
        }
        private void lbTitel_Click(object sender, EventArgs e)
        {
            if (actionTitel != null)
                actionTitel();
        }
        private void rtbInfoText_Click(object sender, EventArgs e)
        {
            if (actionInfo != null)
                actionInfo();

        }

    }
}
