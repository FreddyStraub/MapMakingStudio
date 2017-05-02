using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio
{
    public partial class MapMakingStudio : Form
    {
        public MapMakingStudio()
        {
            InitializeComponent();
        }

        #region Move Form

        private Point mouseposition;

        private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
        {
     
            
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseposition.X, mouseposition.Y);
                Location = mousePos;

                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Normal;

            }
        }

        private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposition = new Point(-e.X, -e.Y);
        }


        #endregion

        /// <summary>
        /// Maximiert bzw. normalisiert übergebenes Formular
        /// </summary>
        /// <param name="frm">zu änderndes Formular</param>
        private void maximizeWindow(Form frm)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            {
                frm.WindowState = FormWindowState.Normal;
                bMaximize.Image = Properties.Resources.maximizeIcon;
            }
            else
            {
                frm.WindowState = FormWindowState.Maximized;
                bMaximize.Image = Properties.Resources.maximizeIcon2;

            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void bMaximize_Click(object sender, EventArgs e)
        {
            maximizeWindow(this);

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximizeWindow(this);
        }
    }
}
