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
            this.bMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbMapMakingStudio = new System.Windows.Forms.Label();
            this.bMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHeaderButtons = new System.Windows.Forms.Panel();
            this.panelTopSeprator = new System.Windows.Forms.Panel();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.panelMenuBarPlaceHolderLeft = new System.Windows.Forms.Panel();
            this.bDatei = new System.Windows.Forms.Button();
            this.bSnippets = new System.Windows.Forms.Button();
            this.bEInstellungen = new System.Windows.Forms.Button();
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaximize)).BeginInit();
            this.panelHeaderButtons.SuspendLayout();
            this.panelMenuBar.SuspendLayout();
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
            this.HeaderBar.Size = new System.Drawing.Size(1149, 61);
            this.HeaderBar.TabIndex = 0;
            this.HeaderBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
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
            this.bMaximize.Zoom = 10;
            this.bMaximize.Click += new System.EventHandler(this.bMaximize_Click);
            // 
            // panelHeaderButtons
            // 
            this.panelHeaderButtons.Controls.Add(this.bMinimize);
            this.panelHeaderButtons.Controls.Add(this.bMaximize);
            this.panelHeaderButtons.Controls.Add(this.bClose);
            this.panelHeaderButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderButtons.Location = new System.Drawing.Point(1015, 0);
            this.panelHeaderButtons.Name = "panelHeaderButtons";
            this.panelHeaderButtons.Size = new System.Drawing.Size(134, 61);
            this.panelHeaderButtons.TabIndex = 6;
            // 
            // panelTopSeprator
            // 
            this.panelTopSeprator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSeprator.Location = new System.Drawing.Point(0, 61);
            this.panelTopSeprator.Name = "panelTopSeprator";
            this.panelTopSeprator.Size = new System.Drawing.Size(1149, 13);
            this.panelTopSeprator.TabIndex = 4;
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.Controls.Add(this.bEInstellungen);
            this.panelMenuBar.Controls.Add(this.bSnippets);
            this.panelMenuBar.Controls.Add(this.bDatei);
            this.panelMenuBar.Controls.Add(this.panelMenuBarPlaceHolderLeft);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 74);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(1149, 32);
            this.panelMenuBar.TabIndex = 5;
            // 
            // panelMenuBarPlaceHolderLeft
            // 
            this.panelMenuBarPlaceHolderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuBarPlaceHolderLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBarPlaceHolderLeft.Name = "panelMenuBarPlaceHolderLeft";
            this.panelMenuBarPlaceHolderLeft.Size = new System.Drawing.Size(10, 32);
            this.panelMenuBarPlaceHolderLeft.TabIndex = 6;
            // 
            // bDatei
            // 
            this.bDatei.BackColor = System.Drawing.Color.ForestGreen;
            this.bDatei.Dock = System.Windows.Forms.DockStyle.Left;
            this.bDatei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDatei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDatei.ForeColor = System.Drawing.Color.White;
            this.bDatei.Location = new System.Drawing.Point(10, 0);
            this.bDatei.Name = "bDatei";
            this.bDatei.Size = new System.Drawing.Size(106, 32);
            this.bDatei.TabIndex = 7;
            this.bDatei.Text = "Datei";
            this.bDatei.UseVisualStyleBackColor = false;
            // 
            // bSnippets
            // 
            this.bSnippets.BackColor = System.Drawing.Color.ForestGreen;
            this.bSnippets.Dock = System.Windows.Forms.DockStyle.Left;
            this.bSnippets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSnippets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSnippets.ForeColor = System.Drawing.Color.White;
            this.bSnippets.Location = new System.Drawing.Point(116, 0);
            this.bSnippets.Name = "bSnippets";
            this.bSnippets.Size = new System.Drawing.Size(106, 32);
            this.bSnippets.TabIndex = 8;
            this.bSnippets.Text = "Snippets";
            this.bSnippets.UseVisualStyleBackColor = false;
            // 
            // bEInstellungen
            // 
            this.bEInstellungen.BackColor = System.Drawing.Color.ForestGreen;
            this.bEInstellungen.Dock = System.Windows.Forms.DockStyle.Left;
            this.bEInstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEInstellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEInstellungen.ForeColor = System.Drawing.Color.White;
            this.bEInstellungen.Location = new System.Drawing.Point(222, 0);
            this.bEInstellungen.Name = "bEInstellungen";
            this.bEInstellungen.Size = new System.Drawing.Size(106, 32);
            this.bEInstellungen.TabIndex = 9;
            this.bEInstellungen.Text = "Einstellungen";
            this.bEInstellungen.UseVisualStyleBackColor = false;
            // 
            // MapMakingStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1149, 611);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.panelTopSeprator);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MapMakingStudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapMakingStudio";
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaximize)).EndInit();
            this.panelHeaderButtons.ResumeLayout(false);
            this.panelMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bClose;
        private System.Windows.Forms.Label lbMapMakingStudio;
        private Bunifu.Framework.UI.BunifuImageButton bMaximize;
        private Bunifu.Framework.UI.BunifuImageButton bMinimize;
        private System.Windows.Forms.Panel panelHeaderButtons;
        private System.Windows.Forms.Panel panelTopSeprator;
        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.Button bDatei;
        private System.Windows.Forms.Panel panelMenuBarPlaceHolderLeft;
        private System.Windows.Forms.Button bEInstellungen;
        private System.Windows.Forms.Button bSnippets;
    }
}

