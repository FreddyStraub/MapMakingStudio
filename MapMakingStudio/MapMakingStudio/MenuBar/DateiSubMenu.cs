using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio.MenuBarSubMenus
{
    public partial class DateiSubMenu : Form
    {
        public DateiSubMenu()
        {
            InitializeComponent();
        }



        private void bNeu_Click(object sender, EventArgs e)
        {

            MapMakingStudio mms = (MapMakingStudio)Application.OpenForms[0];
            mms.tabControl.TabPages.Add(Tabs.Tabs.CreateNewCodeTabPage("Test"));
        }
    }
}
