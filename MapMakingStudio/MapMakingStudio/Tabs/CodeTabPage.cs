using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio.Tabs
{
    public class CodeTabPage : TabPage
    {

        public string Title { get; set; }

        public FastColoredTextBoxNS.FastColoredTextBox fasColoredTextBox { get; set; }

        public CodeTabPage(string title)
        {
            this.Title = title;
            this.Text = title;
            addCodeTabWindow();
        }

        /// <summary>
        /// Fügt das CodeControl hinzu.
        /// </summary>
        private void addCodeTabWindow()
        {

            CodeTab ct = new CodeTab();
            
            ct.TopLevel = false;
            ct.AutoScroll = true;

            ct.Dock = DockStyle.Fill;
            ct.Show();

            fasColoredTextBox = ct.fastColoredTextBox1;

            Controls.Add(ct);

        }

        /// <summary>
        /// Erstellt eine CodeTabPage aus TabPage
        /// </summary>
        /// <param name="tabpage">zu konvertierende TabPage</param>
        /// <returns></returns>
        public CodeTabPage getCodeTabPageFromTabPage(TabPage tabpage)
        {
            CodeTabPage t = new CodeTabPage(tabpage.Text);

            t.fasColoredTextBox = tabpage.Controls.Cast<Control>()
                .SelectMany(page => page.Controls.OfType<FastColoredTextBoxNS.FastColoredTextBox>())
                .First();

            return t;
        }
    }
}
