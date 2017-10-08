namespace MMSFileExplorer
{
    partial class frmInputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputDialog));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.bClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bErstellen = new System.Windows.Forms.Button();
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bClose);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(437, 61);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.ForestGreen;
            this.bClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bClose.ErrorImage")));
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageActive = null;
            this.bClose.Location = new System.Drawing.Point(387, 12);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(35, 35);
            this.bClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bClose.TabIndex = 4;
            this.bClose.TabStop = false;
            this.bClose.Zoom = 10;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bErstellen
            // 
            this.bErstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bErstellen.ForeColor = System.Drawing.Color.White;
            this.bErstellen.Location = new System.Drawing.Point(173, 190);
            this.bErstellen.Name = "bErstellen";
            this.bErstellen.Size = new System.Drawing.Size(123, 39);
            this.bErstellen.TabIndex = 9;
            this.bErstellen.Text = "Erstellen";
            this.bErstellen.UseVisualStyleBackColor = true;
            this.bErstellen.Click += new System.EventHandler(this.bErstellen_Click);
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbbrechen.ForeColor = System.Drawing.Color.White;
            this.bAbbrechen.Location = new System.Drawing.Point(302, 190);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(123, 39);
            this.bAbbrechen.TabIndex = 8;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            this.bAbbrechen.Click += new System.EventHandler(this.bAbbrechen_Click);
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.White;
            this.tbName.LineIdleColor = System.Drawing.Color.White;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.LineThickness = 3;
            this.tbName.Location = new System.Drawing.Point(16, 95);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(406, 44);
            this.tbName.TabIndex = 10;
            this.tbName.Text = "Name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.OnValueChanged += new System.EventHandler(this.tbName_OnValueChanged);
            // 
            // frmInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(437, 245);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bErstellen);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.HeaderBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInputDialog";
            this.Text = "frmInputDialog";
            this.HeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bClose;
        public System.Windows.Forms.Button bErstellen;
        public System.Windows.Forms.Button bAbbrechen;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
    }
}