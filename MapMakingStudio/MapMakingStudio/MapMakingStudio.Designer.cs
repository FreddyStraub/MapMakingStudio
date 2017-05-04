using Bunifu.Framework.UI;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapMakingStudio));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.panelHeaderButtons = new System.Windows.Forms.Panel();
            this.bMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbMapMakingStudio = new System.Windows.Forms.Label();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.panelBearbeiten = new System.Windows.Forms.Panel();
            this.bBearbeiten = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelDatei = new System.Windows.Forms.Panel();
            this.bDatei = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTabBar = new System.Windows.Forms.Panel();
            this.bTab1 = new System.Windows.Forms.Button();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.bSuchen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bEinstellungen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bSnippets = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSnippets = new System.Windows.Forms.Panel();
            this.panelSuche = new System.Windows.Forms.Panel();
            this.panelEinstellungen = new System.Windows.Forms.Panel();
            this.HeaderBar.SuspendLayout();
            this.panelHeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.panelMenuBar.SuspendLayout();
            this.panelBearbeiten.SuspendLayout();
            this.panelDatei.SuspendLayout();
            this.panelTabBar.SuspendLayout();
            this.panelSnippets.SuspendLayout();
            this.panelSuche.SuspendLayout();
            this.panelEinstellungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.panelHeaderButtons);
            this.HeaderBar.Controls.Add(this.lbMapMakingStudio);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(1122, 61);
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
            this.panelHeaderButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderButtons.Location = new System.Drawing.Point(988, 0);
            this.panelHeaderButtons.Name = "panelHeaderButtons";
            this.panelHeaderButtons.Size = new System.Drawing.Size(134, 61);
            this.panelHeaderButtons.TabIndex = 6;
            // 
            // bMinimize
            // 
            this.bMinimize.BackColor = System.Drawing.Color.ForestGreen;
            this.bMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bMaximize.Image = ((System.Drawing.Image)(resources.GetObject("bMaximize.Image")));
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
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 61);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(200, 576);
            this.panelMenuBar.TabIndex = 8;
            // 
            // panelBearbeiten
            // 
            this.panelBearbeiten.Controls.Add(this.bBearbeiten);
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
            // panelTabBar
            // 
            this.panelTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTabBar.Controls.Add(this.bTab1);
            this.panelTabBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabBar.Location = new System.Drawing.Point(200, 61);
            this.panelTabBar.Name = "panelTabBar";
            this.panelTabBar.Size = new System.Drawing.Size(922, 32);
            this.panelTabBar.TabIndex = 9;
            // 
            // bTab1
            // 
            this.bTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bTab1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTab1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTab1.ForeColor = System.Drawing.Color.White;
            this.bTab1.Location = new System.Drawing.Point(0, 0);
            this.bTab1.Name = "bTab1";
            this.bTab1.Size = new System.Drawing.Size(119, 32);
            this.bTab1.TabIndex = 7;
            this.bTab1.Text = "Tab";
            this.bTab1.UseVisualStyleBackColor = false;
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTabs.Location = new System.Drawing.Point(200, 93);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(919, 541);
            this.panelTabs.TabIndex = 10;
            // 
            // bSuchen
            // 
            this.bSuchen.Activecolor = System.Drawing.Color.LimeGreen;
            this.bSuchen.BackColor = System.Drawing.Color.ForestGreen;
            this.bSuchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSuchen.BorderRadius = 0;
            this.bSuchen.ButtonText = "  Suchen";
            this.bSuchen.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // bEinstellungen
            // 
            this.bEinstellungen.Activecolor = System.Drawing.Color.LimeGreen;
            this.bEinstellungen.BackColor = System.Drawing.Color.ForestGreen;
            this.bEinstellungen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEinstellungen.BorderRadius = 0;
            this.bEinstellungen.ButtonText = "  Einstellungen";
            this.bEinstellungen.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // 
            // bSnippets
            // 
            this.bSnippets.Activecolor = System.Drawing.Color.LimeGreen;
            this.bSnippets.BackColor = System.Drawing.Color.ForestGreen;
            this.bSnippets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSnippets.BorderRadius = 0;
            this.bSnippets.ButtonText = "  Snippets";
            this.bSnippets.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // panelSnippets
            // 
            this.panelSnippets.Controls.Add(this.bSnippets);
            this.panelSnippets.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSnippets.Location = new System.Drawing.Point(0, 86);
            this.panelSnippets.Name = "panelSnippets";
            this.panelSnippets.Size = new System.Drawing.Size(200, 43);
            this.panelSnippets.TabIndex = 18;
            // 
            // panelSuche
            // 
            this.panelSuche.Controls.Add(this.bSuchen);
            this.panelSuche.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuche.Location = new System.Drawing.Point(0, 129);
            this.panelSuche.Name = "panelSuche";
            this.panelSuche.Size = new System.Drawing.Size(200, 43);
            this.panelSuche.TabIndex = 18;
            // 
            // panelEinstellungen
            // 
            this.panelEinstellungen.Controls.Add(this.bEinstellungen);
            this.panelEinstellungen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEinstellungen.Location = new System.Drawing.Point(0, 172);
            this.panelEinstellungen.Name = "panelEinstellungen";
            this.panelEinstellungen.Size = new System.Drawing.Size(200, 43);
            this.panelEinstellungen.TabIndex = 17;
            // 
            // MapMakingStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1122, 637);
            this.Controls.Add(this.panelTabs);
            this.Controls.Add(this.panelTabBar);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(667, 334);
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
            this.panelBearbeiten.ResumeLayout(false);
            this.panelDatei.ResumeLayout(false);
            this.panelTabBar.ResumeLayout(false);
            this.panelSnippets.ResumeLayout(false);
            this.panelSuche.ResumeLayout(false);
            this.panelEinstellungen.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelTabBar;
        private System.Windows.Forms.Button bTab1;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Panel panelBearbeiten;
        private BunifuFlatButton bBearbeiten;
        private System.Windows.Forms.Panel panelDatei;
        private BunifuFlatButton bDatei;
        private BunifuFlatButton bSuchen;
        private BunifuFlatButton bEinstellungen;
        private BunifuFlatButton bSnippets;
        private System.Windows.Forms.Panel panelSnippets;
        private System.Windows.Forms.Panel panelSuche;
        private System.Windows.Forms.Panel panelEinstellungen;
    }
}

