using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSFileExplorer
{
    public partial class FileExplorerControl : UserControl
    {
        public FileExplorerControl()
        {
            InitializeComponent();
            Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }


        public string Path { get; set; }

        FileExplorer fe = new FileExplorer();

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


        #region Custom Events

        #region NodePathChanged

        // declare the event
        public event EventHandler NodePathChanged;

        // declare backing field for the property
        private string _nodepath;

        public string SelectedNodePath
        {
            get { return _nodepath; }
            set
            {
                // bool indicating whether the new value is indeed 
                // different from the old one
                bool raiseEvent = _nodepath != value;
                // assign the value to the backing field
                _nodepath = value;
                // raise the event if the value has changed
                if (raiseEvent)
                {
                    OnNodePathChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnNodePathChanged(EventArgs e)
        {
            EventHandler temp = this.NodePathChanged;
            // make sure that there is an event handler attached
            if (temp != null)
            {
                temp(this, e);
            }
        }


        #endregion

        #endregion

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {

                int parentNodeLength = treeView1.Nodes[0].Text.Length;
                string sNode = treeView1.SelectedNode.FullPath;
                string fullPath = Path.Substring(0, Path.Length - parentNodeLength) + sNode;

                SelectedNodePath = fullPath;
            }
        }
    }
}
