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

        public static CodeTabPage CreateNewCodeTabPage(string title){

            CodeTabPage tnew = new CodeTabPage(title);
            return tnew;

        }

    }
}
