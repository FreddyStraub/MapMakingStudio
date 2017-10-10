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

    }
}
