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
            tabcontrol.TabPages.Add(tnew);

        }

    }
}
