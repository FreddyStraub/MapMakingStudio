using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio.Tabs
{
    public class Tabs
    {

        public static void CreateNewTab(VisualStudioTabControl.VisualStudioTabControl tabcontrol){

            TabPage tnew = new TabPage("TEST");

            CodeTab ct = new CodeTab();


           ct.TopLevel = false;
           ct.AutoScroll = true;     

            tnew.Controls.Add(ct);
            ct.Dock = DockStyle.Fill;
            ct.Show();

            tabcontrol.TabPages.Add(tnew);

        }

    }
}
