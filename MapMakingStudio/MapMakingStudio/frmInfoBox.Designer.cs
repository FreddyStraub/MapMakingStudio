﻿namespace MapMakingStudio
{
    partial class frmInfoBox
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoBox));
            this.lbTitel = new System.Windows.Forms.Label();
            this.rtbInfoText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.Location = new System.Drawing.Point(126, 16);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(52, 30);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Titel";
            this.lbTitel.Click += new System.EventHandler(this.lbTitel_Click);
            // 
            // rtbInfoText
            // 
            this.rtbInfoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfoText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfoText.ForeColor = System.Drawing.Color.White;
            this.rtbInfoText.Location = new System.Drawing.Point(131, 59);
            this.rtbInfoText.Name = "rtbInfoText";
            this.rtbInfoText.ReadOnly = true;
            this.rtbInfoText.Size = new System.Drawing.Size(363, 100);
            this.rtbInfoText.TabIndex = 2;
            this.rtbInfoText.Text = "";
            this.rtbInfoText.Click += new System.EventHandler(this.rtbInfoText_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(14, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Transparent;
            this.bClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bClose.ErrorImage")));
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageActive = null;
            this.bClose.Location = new System.Drawing.Point(459, 11);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(35, 35);
            this.bClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bClose.TabIndex = 4;
            this.bClose.TabStop = false;
            this.bClose.Zoom = 10;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // frmInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.rtbInfoText);
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmInfoBox";
            this.Size = new System.Drawing.Size(503, 192);
            this.Load += new System.EventHandler(this.frmInfoBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.RichTextBox rtbInfoText;
        private Bunifu.Framework.UI.BunifuImageButton bClose;
    }
}
