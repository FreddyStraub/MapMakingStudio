using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace MapMakingStudio
{
    partial class MapMakingStudio
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapMakingStudio));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.panelHeaderButtons = new System.Windows.Forms.Panel();
            this.bMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbMapMakingStudio = new System.Windows.Forms.Label();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.panelEinstellungen = new System.Windows.Forms.Panel();
            this.bEinstellungen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSuche = new System.Windows.Forms.Panel();
            this.bSuchen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSnippets = new System.Windows.Forms.Panel();
            this.bSnippets = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelBearbeiten = new System.Windows.Forms.Panel();
            this.bBearbeiten = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelDatei = new System.Windows.Forms.Panel();
            this.bDatei = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuBarAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tabControl = new VisualStudioTabControl.VisualStudioTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HeaderBar.SuspendLayout();
            this.panelHeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.panelMenuBar.SuspendLayout();
            this.panelEinstellungen.SuspendLayout();
            this.panelSuche.SuspendLayout();
            this.panelSnippets.SuspendLayout();
            this.panelBearbeiten.SuspendLayout();
            this.panelDatei.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.panelHeaderButtons);
            this.HeaderBar.Controls.Add(this.lbMapMakingStudio);
            this.MenuBarAnimator.SetDecoration(this.HeaderBar, BunifuAnimatorNS.DecorationType.None);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(1127, 61);
            this.HeaderBar.TabIndex = 0;
            this.HeaderBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // panelHeaderButtons
            // 
            this.panelHeaderButtons.Controls.Add(this.bMinimize);
            this.panelHeaderButtons.Controls.Add(this.bMaximize);
            this.panelHeaderButtons.Controls.Add(this.bClose);
            this.MenuBarAnimator.SetDecoration(this.panelHeaderButtons, BunifuAnimatorNS.DecorationType.None);
            this.panelHeaderButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderButtons.Location = new System.Drawing.Point(993, 0);
            this.panelHeaderButtons.Name = "panelHeaderButtons";
            this.panelHeaderButtons.Size = new System.Drawing.Size(134, 61);
            this.panelHeaderButtons.TabIndex = 6;
            // 
            // bMinimize
            // 
            this.bMinimize.BackColor = System.Drawing.Color.ForestGreen;
            this.bMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bMinimize, BunifuAnimatorNS.DecorationType.None);
            this.bMinimize.Image = ((System.Drawing.Image)(resources.GetObject("bMinimize.Image")));
            this.bMinimize.ImageActive = null;
            this.bMinimize.Location = new System.Drawing.Point(3, 12);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(35, 35);
            this.bMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bMinimize.TabIndex = 4;
            this.bMinimize.TabStop = false;
            this.bMinimize.Zoom = 10;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bMaximize
            // 
            this.bMaximize.BackColor = System.Drawing.Color.ForestGreen;
            this.bMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bMaximize, BunifuAnimatorNS.DecorationType.None);
            this.bMaximize.Image = global::MapMakingStudio.Properties.Resources.maximizeIcon;
            this.bMaximize.ImageActive = null;
            this.bMaximize.Location = new System.Drawing.Point(44, 12);
            this.bMaximize.Name = "bMaximize";
            this.bMaximize.Size = new System.Drawing.Size(35, 35);
            this.bMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bMaximize.TabIndex = 5;
            this.bMaximize.TabStop = false;
            this.bMaximize.Zoom = 5;
            this.bMaximize.Click += new System.EventHandler(this.bMaximize_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.ForestGreen;
            this.bClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bClose, BunifuAnimatorNS.DecorationType.None);
            this.bClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bClose.ErrorImage")));
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageActive = null;
            this.bClose.Location = new System.Drawing.Point(85, 12);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(35, 35);
            this.bClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bClose.TabIndex = 3;
            this.bClose.TabStop = false;
            this.bClose.Zoom = 10;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lbMapMakingStudio
            // 
            this.lbMapMakingStudio.AutoSize = true;
            this.MenuBarAnimator.SetDecoration(this.lbMapMakingStudio, BunifuAnimatorNS.DecorationType.None);
            this.lbMapMakingStudio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMapMakingStudio.ForeColor = System.Drawing.Color.White;
            this.lbMapMakingStudio.Location = new System.Drawing.Point(12, 22);
            this.lbMapMakingStudio.Name = "lbMapMakingStudio";
            this.lbMapMakingStudio.Size = new System.Drawing.Size(238, 21);
            this.lbMapMakingStudio.TabIndex = 1;
            this.lbMapMakingStudio.Text = "MapMakingStudio by Wolf066LP";
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMenuBar.Controls.Add(this.panelEinstellungen);
            this.panelMenuBar.Controls.Add(this.panelSuche);
            this.panelMenuBar.Controls.Add(this.panelSnippets);
            this.panelMenuBar.Controls.Add(this.panelBearbeiten);
            this.panelMenuBar.Controls.Add(this.panelDatei);
            this.MenuBarAnimator.SetDecoration(this.panelMenuBar, BunifuAnimatorNS.DecorationType.None);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 61);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(200, 573);
            this.panelMenuBar.TabIndex = 8;
            // 
            // panelEinstellungen
            // 
            this.panelEinstellungen.Controls.Add(this.bEinstellungen);
            this.MenuBarAnimator.SetDecoration(this.panelEinstellungen, BunifuAnimatorNS.DecorationType.None);
            this.panelEinstellungen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEinstellungen.Location = new System.Drawing.Point(0, 172);
            this.panelEinstellungen.Name = "panelEinstellungen";
            this.panelEinstellungen.Size = new System.Drawing.Size(200, 43);
            this.panelEinstellungen.TabIndex = 17;
            // 
            // bEinstellungen
            // 
            this.bEinstellungen.Activecolor = System.Drawing.Color.LimeGreen;
            this.bEinstellungen.BackColor = System.Drawing.Color.ForestGreen;
            this.bEinstellungen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEinstellungen.BorderRadius = 0;
            this.bEinstellungen.ButtonText = "  Einstellungen";
            this.bEinstellungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bEinstellungen, BunifuAnimatorNS.DecorationType.None);
            this.bEinstellungen.DisabledColor = System.Drawing.Color.Gray;
            this.bEinstellungen.Iconcolor = System.Drawing.Color.Transparent;
            this.bEinstellungen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bEinstellungen.Iconimage")));
            this.bEinstellungen.Iconimage_right = null;
            this.bEinstellungen.Iconimage_right_Selected = null;
            this.bEinstellungen.Iconimage_Selected = null;
            this.bEinstellungen.IconMarginLeft = 0;
            this.bEinstellungen.IconMarginRight = 0;
            this.bEinstellungen.IconRightVisible = true;
            this.bEinstellungen.IconRightZoom = 0D;
            this.bEinstellungen.IconVisible = true;
            this.bEinstellungen.IconZoom = 50D;
            this.bEinstellungen.IsTab = false;
            this.bEinstellungen.Location = new System.Drawing.Point(0, 0);
            this.bEinstellungen.Name = "bEinstellungen";
            this.bEinstellungen.Normalcolor = System.Drawing.Color.ForestGreen;
            this.bEinstellungen.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bEinstellungen.OnHoverTextColor = System.Drawing.Color.White;
            this.bEinstellungen.selected = false;
            this.bEinstellungen.Size = new System.Drawing.Size(200, 44);
            this.bEinstellungen.TabIndex = 16;
            this.bEinstellungen.Text = "  Einstellungen";
            this.bEinstellungen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEinstellungen.Textcolor = System.Drawing.Color.White;
            this.bEinstellungen.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEinstellungen.Click += new System.EventHandler(this.bEinstellungen_Click);
            // 
            // panelSuche
            // 
            this.panelSuche.Controls.Add(this.bSuchen);
            this.MenuBarAnimator.SetDecoration(this.panelSuche, BunifuAnimatorNS.DecorationType.None);
            this.panelSuche.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuche.Location = new System.Drawing.Point(0, 129);
            this.panelSuche.Name = "panelSuche";
            this.panelSuche.Size = new System.Drawing.Size(200, 43);
            this.panelSuche.TabIndex = 18;
            // 
            // bSuchen
            // 
            this.bSuchen.Activecolor = System.Drawing.Color.LimeGreen;
            this.bSuchen.BackColor = System.Drawing.Color.ForestGreen;
            this.bSuchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSuchen.BorderRadius = 0;
            this.bSuchen.ButtonText = "  Suchen";
            this.bSuchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bSuchen, BunifuAnimatorNS.DecorationType.None);
            this.bSuchen.DisabledColor = System.Drawing.Color.Gray;
            this.bSuchen.Iconcolor = System.Drawing.Color.Transparent;
            this.bSuchen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bSuchen.Iconimage")));
            this.bSuchen.Iconimage_right = null;
            this.bSuchen.Iconimage_right_Selected = null;
            this.bSuchen.Iconimage_Selected = null;
            this.bSuchen.IconMarginLeft = 0;
            this.bSuchen.IconMarginRight = 0;
            this.bSuchen.IconRightVisible = true;
            this.bSuchen.IconRightZoom = 0D;
            this.bSuchen.IconVisible = true;
            this.bSuchen.IconZoom = 50D;
            this.bSuchen.IsTab = false;
            this.bSuchen.Location = new System.Drawing.Point(0, 0);
            this.bSuchen.Name = "bSuchen";
            this.bSuchen.Normalcolor = System.Drawing.Color.ForestGreen;
            this.bSuchen.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bSuchen.OnHoverTextColor = System.Drawing.Color.White;
            this.bSuchen.selected = false;
            this.bSuchen.Size = new System.Drawing.Size(200, 44);
            this.bSuchen.TabIndex = 17;
            this.bSuchen.Text = "  Suchen";
            this.bSuchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSuchen.Textcolor = System.Drawing.Color.White;
            this.bSuchen.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelSnippets
            // 
            this.panelSnippets.Controls.Add(this.bSnippets);
            this.MenuBarAnimator.SetDecoration(this.panelSnippets, BunifuAnimatorNS.DecorationType.None);
            this.panelSnippets.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSnippets.Location = new System.Drawing.Point(0, 86);
            this.panelSnippets.Name = "panelSnippets";
            this.panelSnippets.Size = new System.Drawing.Size(200, 43);
            this.panelSnippets.TabIndex = 18;
            // 
            // bSnippets
            // 
            this.bSnippets.Activecolor = System.Drawing.Color.LimeGreen;
            this.bSnippets.BackColor = System.Drawing.Color.ForestGreen;
            this.bSnippets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSnippets.BorderRadius = 0;
            this.bSnippets.ButtonText = "  Snippets";
            this.bSnippets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bSnippets, BunifuAnimatorNS.DecorationType.None);
            this.bSnippets.DisabledColor = System.Drawing.Color.Gray;
            this.bSnippets.Iconcolor = System.Drawing.Color.Transparent;
            this.bSnippets.Iconimage = ((System.Drawing.Image)(resources.GetObject("bSnippets.Iconimage")));
            this.bSnippets.Iconimage_right = null;
            this.bSnippets.Iconimage_right_Selected = null;
            this.bSnippets.Iconimage_Selected = null;
            this.bSnippets.IconMarginLeft = 0;
            this.bSnippets.IconMarginRight = 0;
            this.bSnippets.IconRightVisible = true;
            this.bSnippets.IconRightZoom = 0D;
            this.bSnippets.IconVisible = true;
            this.bSnippets.IconZoom = 50D;
            this.bSnippets.IsTab = false;
            this.bSnippets.Location = new System.Drawing.Point(0, 0);
            this.bSnippets.Name = "bSnippets";
            this.bSnippets.Normalcolor = System.Drawing.Color.ForestGreen;
            this.bSnippets.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bSnippets.OnHoverTextColor = System.Drawing.Color.White;
            this.bSnippets.selected = false;
            this.bSnippets.Size = new System.Drawing.Size(200, 44);
            this.bSnippets.TabIndex = 15;
            this.bSnippets.Text = "  Snippets";
            this.bSnippets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSnippets.Textcolor = System.Drawing.Color.White;
            this.bSnippets.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelBearbeiten
            // 
            this.panelBearbeiten.Controls.Add(this.bBearbeiten);
            this.MenuBarAnimator.SetDecoration(this.panelBearbeiten, BunifuAnimatorNS.DecorationType.None);
            this.panelBearbeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBearbeiten.Location = new System.Drawing.Point(0, 43);
            this.panelBearbeiten.Name = "panelBearbeiten";
            this.panelBearbeiten.Size = new System.Drawing.Size(200, 43);
            this.panelBearbeiten.TabIndex = 18;
            // 
            // bBearbeiten
            // 
            this.bBearbeiten.Activecolor = System.Drawing.Color.LimeGreen;
            this.bBearbeiten.BackColor = System.Drawing.Color.ForestGreen;
            this.bBearbeiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBearbeiten.BorderRadius = 0;
            this.bBearbeiten.ButtonText = "  Bearbeiten";
            this.bBearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bBearbeiten, BunifuAnimatorNS.DecorationType.None);
            this.bBearbeiten.DisabledColor = System.Drawing.Color.Gray;
            this.bBearbeiten.Iconcolor = System.Drawing.Color.Transparent;
            this.bBearbeiten.Iconimage = ((System.Drawing.Image)(resources.GetObject("bBearbeiten.Iconimage")));
            this.bBearbeiten.Iconimage_right = null;
            this.bBearbeiten.Iconimage_right_Selected = null;
            this.bBearbeiten.Iconimage_Selected = null;
            this.bBearbeiten.IconMarginLeft = 0;
            this.bBearbeiten.IconMarginRight = 0;
            this.bBearbeiten.IconRightVisible = true;
            this.bBearbeiten.IconRightZoom = 0D;
            this.bBearbeiten.IconVisible = true;
            this.bBearbeiten.IconZoom = 47D;
            this.bBearbeiten.IsTab = false;
            this.bBearbeiten.Location = new System.Drawing.Point(0, 0);
            this.bBearbeiten.Name = "bBearbeiten";
            this.bBearbeiten.Normalcolor = System.Drawing.Color.ForestGreen;
            this.bBearbeiten.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bBearbeiten.OnHoverTextColor = System.Drawing.Color.White;
            this.bBearbeiten.selected = false;
            this.bBearbeiten.Size = new System.Drawing.Size(200, 44);
            this.bBearbeiten.TabIndex = 14;
            this.bBearbeiten.Text = "  Bearbeiten";
            this.bBearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBearbeiten.Textcolor = System.Drawing.Color.White;
            this.bBearbeiten.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBearbeiten.Click += new System.EventHandler(this.bBearbeiten_Click);
            // 
            // panelDatei
            // 
            this.panelDatei.Controls.Add(this.bDatei);
            this.MenuBarAnimator.SetDecoration(this.panelDatei, BunifuAnimatorNS.DecorationType.None);
            this.panelDatei.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatei.Location = new System.Drawing.Point(0, 0);
            this.panelDatei.Name = "panelDatei";
            this.panelDatei.Size = new System.Drawing.Size(200, 43);
            this.panelDatei.TabIndex = 18;
            // 
            // bDatei
            // 
            this.bDatei.Activecolor = System.Drawing.Color.LimeGreen;
            this.bDatei.BackColor = System.Drawing.Color.ForestGreen;
            this.bDatei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDatei.BorderRadius = 0;
            this.bDatei.ButtonText = "  Datei";
            this.bDatei.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBarAnimator.SetDecoration(this.bDatei, BunifuAnimatorNS.DecorationType.None);
            this.bDatei.DisabledColor = System.Drawing.Color.Gray;
            this.bDatei.Iconcolor = System.Drawing.Color.Transparent;
            this.bDatei.Iconimage = ((System.Drawing.Image)(resources.GetObject("bDatei.Iconimage")));
            this.bDatei.Iconimage_right = null;
            this.bDatei.Iconimage_right_Selected = null;
            this.bDatei.Iconimage_Selected = null;
            this.bDatei.IconMarginLeft = 0;
            this.bDatei.IconMarginRight = 0;
            this.bDatei.IconRightVisible = true;
            this.bDatei.IconRightZoom = 0D;
            this.bDatei.IconVisible = true;
            this.bDatei.IconZoom = 50D;
            this.bDatei.IsTab = false;
            this.bDatei.Location = new System.Drawing.Point(0, 0);
            this.bDatei.Name = "bDatei";
            this.bDatei.Normalcolor = System.Drawing.Color.ForestGreen;
            this.bDatei.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bDatei.OnHoverTextColor = System.Drawing.Color.White;
            this.bDatei.selected = false;
            this.bDatei.Size = new System.Drawing.Size(200, 44);
            this.bDatei.TabIndex = 13;
            this.bDatei.Text = "  Datei";
            this.bDatei.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDatei.Textcolor = System.Drawing.Color.White;
            this.bDatei.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDatei.Click += new System.EventHandler(this.bDatei_Click);
            // 
            // MenuBarAnimator
            // 
            this.MenuBarAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.MenuBarAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.MenuBarAnimator.DefaultAnimation = animation1;
            this.MenuBarAnimator.Interval = 1000;
            this.MenuBarAnimator.TimeStep = 0.1F;
            // 
            // tabControl
            // 
            this.tabControl.ActiveColor = System.Drawing.Color.ForestGreen;
            this.tabControl.AllowDrop = true;
            this.tabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabControl.ClosingButtonColor = System.Drawing.Color.White;
            this.tabControl.ClosingMessage = null;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.MenuBarAnimator.SetDecoration(this.tabControl, BunifuAnimatorNS.DecorationType.None);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabControl.HorizontalLineColor = System.Drawing.Color.ForestGreen;
            this.tabControl.ItemSize = new System.Drawing.Size(240, 16);
            this.tabControl.Location = new System.Drawing.Point(201, 61);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControl.ShowClosingButton = true;
            this.tabControl.ShowClosingMessage = false;
            this.tabControl.Size = new System.Drawing.Size(914, 561);
            this.tabControl.TabIndex = 9;
            this.tabControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MenuBarAnimator.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MenuBarAnimator.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MenuBarAnimator.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(906, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // MapMakingStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1127, 634);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.HeaderBar);
            this.MenuBarAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(667, 550);
            this.Name = "MapMakingStudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapMakingStudio";
            this.Resize += new System.EventHandler(this.MapMakingStudio_Resize);
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            this.panelHeaderButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.panelMenuBar.ResumeLayout(false);
            this.panelEinstellungen.ResumeLayout(false);
            this.panelSuche.ResumeLayout(false);
            this.panelSnippets.ResumeLayout(false);
            this.panelBearbeiten.ResumeLayout(false);
            this.panelDatei.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bClose;
        private System.Windows.Forms.Label lbMapMakingStudio;
        private Bunifu.Framework.UI.BunifuImageButton bMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bMinimize;
        private System.Windows.Forms.Panel panelHeaderButtons;
        private System.Windows.Forms.Panel panelMenuBar;
        private BunifuFlatButton bSuchen;
        private BunifuFlatButton bEinstellungen;
        private BunifuFlatButton bSnippets;
        private System.Windows.Forms.Panel panelSnippets;
        private System.Windows.Forms.Panel panelSuche;
        private System.Windows.Forms.Panel panelEinstellungen;
        public System.Windows.Forms.Panel panelBearbeiten;
        public BunifuFlatButton bBearbeiten;
        public System.Windows.Forms.Panel panelDatei;
        public BunifuFlatButton bDatei;
        public BunifuTransition MenuBarAnimator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public VisualStudioTabControl.VisualStudioTabControl tabControl;
    }
}

