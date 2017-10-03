using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio.FileExplorer
{
    public partial class FileExplorerControl : UserControl
    {
        public string Path { get; set; }
        public string Heading { get; set; }

        FileExplorer fe = new FileExplorer();

        public FileExplorerControl()
        {
            InitializeComponent();
            Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

    
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                TreeNode node = fe.EnumerateDirectory(e.Node);
            }
        }

        private void FileExplorerControl_Load(object sender, EventArgs e)
        {
            fe.CreateTree(this.treeView1, Path);

        }
    }
}
