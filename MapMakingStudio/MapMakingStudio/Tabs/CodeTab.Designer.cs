﻿namespace MapMakingStudio.Tabs
{
    partial class CodeTab
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
            this.components = new System.ComponentModel.Container();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fastColoredTextBox1.BookmarkColor = System.Drawing.Color.ForestGreen;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "#";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(903, 502);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "fastColoredTextBox1";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            // 
            // CodeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(903, 502);
            this.Controls.Add(this.fastColoredTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodeTab";
            this.Text = "CodeTabe";
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}