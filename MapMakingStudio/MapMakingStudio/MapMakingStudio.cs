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
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts

            generatePanelTabsSize();
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

        #region Rezize Form

        private const int
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
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

        private void bDatei_Click(object sender, EventArgs e)
        {
            MenuBar(Menus.Datei, MenuStatus.Open);
        }


        /// <summary>
        /// Passt das panelTab-Usercontrol auf die aktuelle Größe an.
        /// </summary>
        private void generatePanelTabsSize()
        {

            int width = this.Size.Width - panelMenuBar.Width - 3;
            int height = this.Size.Height - panelTabBar.Height - HeaderBar.Height - 3;

            panelTabs.Size = new Size(width, height);
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

        private void bBearbeiten_Click(object sender, EventArgs e)
        {
            MenuBar(Menus.Bearbeiten, MenuStatus.Open);
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximizeWindow(this);
        }
        private void MapMakingStudio_Resize(object sender, EventArgs e)
        {
            generatePanelTabsSize();

            if (WindowState == FormWindowState.Normal)
                bMaximize.Image = Properties.Resources.maximizeIcon;

        }

        #region Sub Menus

        private enum Menus { Datei, Bearbeiten, Snippets, Suche, Einstellungen};
        private enum MenuStatus { Open, Close };

        #region MenuSelected Bools

        /// <summary>
        /// Gibt an ob dateiMenu geöffnet ist.
        /// </summary>
        private bool dateiMenuSelected = false;

        /// <summary>
        /// Gibt an ob bearbeitenMenu geöffnet ist.
        /// </summary>

        private bool bearbeitenMenuSelected = false;

        /// <summary>
        /// Gibt an ob SnippetsMenu geöffnet ist.
        /// </summary>

        private bool snippetsMenuSelected = false;

        #endregion


        private void MenuBar(Menus menu, MenuStatus menustatus)
        {

            closeAllMenus();

            switch (menu)
            {
                case Menus.Datei: DateiMenu() ; break;
                case Menus.Bearbeiten: openBearbeitenMenu(); break;
                case Menus.Snippets: openSnippetsMenu(); break;
                case Menus.Suche: openSucheMenu(); break;
                case Menus.Einstellungen: openEinstellungenMenu(); break;
            }



            #region Methoden für einzelne Menus




            /// <summary>
            /// Öffnet das DateiMenu
            /// </summary>
            void DateiMenu()
            {

                MenuBarSubMenus.DateiSubMenu submenu = new MenuBarSubMenus.DateiSubMenu();

                #region Creating Menu Form

                submenu.TopLevel = false;
                submenu.AutoScroll = true;

                panelDatei.Controls.Add(submenu);

                submenu.Location = new Point(panelDatei.Location.X, panelDatei.Location.Y + bDatei.Height);

                submenu.Show();

                #endregion
                
                if(menustatus == MenuStatus.Open) { 
                    panelDatei.Size = new Size(panelDatei.Width, submenu.Height);
                    dateiMenuSelected = true;

                }else

                {
                    panelDatei.Size = new Size(panelDatei.Width, bDatei.Height - 1);
                    dateiMenuSelected = false;


                }



            }


            /// <summary>
            /// Öffnet das BearbeitenMenu
            /// </summary>
            void openBearbeitenMenu()
            {

                MenuBarSubMenus.DateiSubMenu submenu = new MenuBarSubMenus.DateiSubMenu();

                #region Creating Menu Form

                submenu.TopLevel = false;
                submenu.AutoScroll = true;

                panelBearbeiten.Controls.Add(submenu);

                submenu.Location = new Point(panelBearbeiten.Location.X, panelBearbeiten.Location.Y + bBearbeiten.Height);

                submenu.Show();

                #endregion

                if (dateiMenuSelected)
                {
                    panelBearbeiten.Size = new Size(panelBearbeiten.Width, bBearbeiten.Height - 1);
                    bearbeitenMenuSelected = false;
                }
                else
                {
                    panelBearbeiten.Size = new Size(panelBearbeiten.Width, submenu.Height);
                    bearbeitenMenuSelected = true;

                }

            }

            /// <summary>
            /// Öffnet das SnippetsMenu
            /// </summary>
            void openSnippetsMenu()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Öffnet das SucheMenu
            /// </summary>
            void openSucheMenu()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Öffnet die Einstellungen
            /// </summary>
            void openEinstellungenMenu()
            {
                throw new NotImplementedException();
            }

            #endregion

        }

        private void closeAllMenus()
        {
            MenuBar(Menus.Datei, MenuStatus.Close);
        }


        #endregion

    }
}
