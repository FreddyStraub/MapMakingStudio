using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapMakingStudio.MenuBar;
using MapMakingStudio.Tabs;

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

            MenuBar = new MenuBar.MenuBar(this);

            closeAllTabs();

            loadSettings();
            assignEvents();

            FileExplorerControl1.Path = FileExplorerPath;

            Controls.Add(infoBox);


        }

        /// <summary>
        /// Lädt UserSettings.
        /// </summary>
        private void loadSettings()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            Settings = new Settings();

            if (!System.IO.Directory.Exists(appDataPath + "\\MapMakingStudio"))
                System.IO.Directory.CreateDirectory(appDataPath + "\\MapMakingStudio");

            if (System.IO.File.Exists(appDataPath + "\\MapMakingStudio\\Settings.wolf"))
            {
                Settings = Settings.Load( appDataPath + "\\MapMakingStudio\\Settings.wolf");

            }
            else
            {

                Settings newSettings = new Settings();
                newSettings.setStandartSettings();
                newSettings.Save(appDataPath + "\\MapMakingStudio\\Settings.wolf");

                Settings = Settings.Load(appDataPath + "\\MapMakingStudio\\Settings.wolf");
            }

            FileExplorerPath = Settings.fileExplorerPath;

        }

        public enum Menus { Datei, Bearbeiten, Snippets, Suche, Einstellungen };
        public enum MenuStatus { Open, Close };

        public frmInfoBox infoBox = new frmInfoBox("", "","");

        public MenuBar.MenuBar MenuBar;

        string FileExplorerPath;

        public Settings Settings { get; set; }

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

        #region MenuBarClickEvents

        private void bDatei_Click(object sender, EventArgs e)
        {
            if (MenuBar.dateiMenuIsOpen)
            {
                MenuBar.toggle(Menus.Datei, MenuStatus.Close);
            }
            else
            {
                MenuBar.toggle(Menus.Datei, MenuStatus.Open);

            }
        }
        private void bBearbeiten_Click(object sender, EventArgs e)
        {

            if (MenuBar.bearbeitenMenuIsOpen)
            {
                MenuBar.toggle(Menus.Bearbeiten, MenuStatus.Close);
            }
            else
            {
                MenuBar.toggle(Menus.Bearbeiten, MenuStatus.Open);

            }



        }

        private void bEinstellungen_Click(object sender, EventArgs e)
        {
            FileExplorerControl1.Path = "C:\\Users\\Freddy Straub\\AppData\\Roaming";
        }


        #endregion

        /// <summary>
        /// Passt das panelTab-Usercontrol auf die aktuelle Größe an.
        /// </summary>
        private void generatePanelTabsSize()
        {

            int width = this.Size.Width - panelMenuBar.Width - 3;
            int height = this.Size.Height - HeaderBar.Height - 3;

            tabControl.Size = new Size(width, height);
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

        private void MapMakingStudio_Resize(object sender, EventArgs e)
        {
            generatePanelTabsSize();

            if (WindowState == FormWindowState.Normal)
                bMaximize.Image = Properties.Resources.maximizeIcon;

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            setInfoBoxPosition();
        }

        /// <summary>
        /// Schließt alle Tabs
        /// </summary>
        private void closeAllTabs()
        {

            foreach (TabPage t in tabControl.TabPages)
            {
                tabControl.TabPages.Remove(t);

            }

        }

      
        /// <summary>
        /// Weißt die "externen" Events zu
        /// </summary>
        private void assignEvents()
        {
            //FileExplorer
            FileExplorerControl1.NodeHoverPathChanged += new EventHandler(fileExplorer1_HoverPathChanged);
            FileExplorerControl1.contextMenuStrip1.Items["öffnenToolStripMenuItem"].Click += new EventHandler(fileExplorer1_openClickEvent);
        }



        /// <summary>
        /// Öffnet Datei.
        /// </summary>
        /// <param name="Path">Pfad der Datei</param>
        private void openFile(string Path)
        {
            if (System.IO.Path.GetExtension(Path) != "")
            {
                bool fileOpened = false;

                foreach (TabPage tp in tabControl.TabPages)
                {
                    if (tp.Text == System.IO.Path.GetFileName(Path))
                    {
                        fileOpened = true;
                    }
              
                }

                if (fileOpened == false)
                {
                    //Wenn Datei noch nicht geöffnet
                    string tabPageName = System.IO.Path.GetFileName(Path);
                    CodeTabPage t = Tabs.Tabs.CreateNewCodeTabPage(tabPageName);

                    System.IO.StreamReader sr = new System.IO.StreamReader(Path);
                    string tcode = "";

                    tcode += sr.ReadToEnd();

                    sr.Close();

                    t.fasColoredTextBox.Text = tcode;

                    tabControl.TabPages.Add(t);
                    tabControl.SelectTab(tabControl.TabPages.IndexOf(t));
                }
                else
                {
                    //Wenn Datei geöffnet
                    foreach (TabPage tp in tabControl.TabPages)
                    {
                        if (tp.Text == System.IO.Path.GetFileName(Path))
                        {
                            tabControl.SelectedTab = tp;
                        }

                    }

                }
            }
        }

        #region FileExplorerEvents

        private void fileExplorer1_HoverPathChanged(object sender, EventArgs e)
        {
            string fullPath = FileExplorerControl1.NodeHoverPath;
            string fileExtention = System.IO.Path.GetExtension(fullPath);

            

            if (fileExtention.ToLower() == ".png" || fileExtention.ToLower() == ".jpg")
            {
                displayTexture(fullPath);
                

            }
            else
            {
                if(infoBox != null)
                    infoBox.Hide();
            }
        }
        private void fileExplorer1_openClickEvent(object sender, EventArgs e)
        {
            string filePath = FileExplorerControl1.SelectedNodePath;
            string fileExtention = System.IO.Path.GetExtension(filePath);

            openFile(filePath);
        }


        #endregion

        /// <summary>
        /// Zeigt eine Textur in der textureBox an.
        /// </summary>
        /// <param name="filePath">Pfad zu Datei.</param>
        private void displayTexture(string filePath)
        {
            string fileName = System.IO.Path.GetFileName(filePath);

            displayInfo(filePath, fileName, filePath);
   
        }

        /// <summary>
        /// Zeigt eine Info im Info-Bereich.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="titel"></param>
        /// <param name="pic"></param>
        private void displayInfo(string info, string titel, string pic)
        {

            infoBox = new frmInfoBox(titel, info, pic);

            
            Controls.Add(infoBox);

            setInfoBoxPosition();

            infoBox.BringToFront();


            infoBox.Show();


        }

        /// <summary>
        /// Ändert die Position der Infobox und passt sie an die Fenstergröße an.
        /// </summary>
        private void setInfoBoxPosition()
        {
            Point position = new Point(this.Width - infoBox.Width - 20, panelHeaderButtons.Height + 40);
            infoBox.Location = position;

        }

    }
}

