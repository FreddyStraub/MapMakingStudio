using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MMSFileExplorer
{
    public partial class FileExplorerControl : UserControl
    {
        public FileExplorerControl()
        {
            InitializeComponent();
            Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            PathChanged += new EventHandler(this_pathChanged);

        }

        private void this_pathChanged(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();
            fe.CreateTree(this.treeView1, Path);

        }


        //  public string Path { get; set; }

        FileExplorer fe = new FileExplorer();

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                TreeNode node = fe.EnumerateDirectory(e.Node);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
                SelectedNodePath = getFullPathFromNode(treeView1.SelectedNode);

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
        #region NodeHoverPathChanged

        // declare the event
        public event EventHandler NodeHoverPathChanged;

        // declare backing field for the property
        private string _hovernodepath;

        public string NodeHoverPath
        {
            get { return _hovernodepath; }
            set
            {
                // bool indicating whether the new value is indeed 
                // different from the old one
                bool raiseEvent = _hovernodepath != value;
                // assign the value to the backing field
                _hovernodepath = value;
                // raise the event if the value has changed
                if (raiseEvent)
                {
                    OnHoverNodePathChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnHoverNodePathChanged(EventArgs e)
        {
            EventHandler temp = this.NodeHoverPathChanged;
            // make sure that there is an event handler attached
            if (temp != null)
            {
                temp(this, e);
            }
        }


        #endregion
        #region PathChanged

        // declare the event
        public event EventHandler PathChanged;

        // declare backing field for the property
        private string _path;

        public string Path
        {
            get { return _path; }
            set
            {
                // bool indicating whether the new value is indeed 
                // different from the old one
                bool raiseEvent = _path != value;
                // assign the value to the backing field
                _path = value;
                // raise the event if the value has changed
                if (raiseEvent)
                {
                    OnPathChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnPathChanged(EventArgs e)
        {
            EventHandler temp = this.PathChanged;
            // make sure that there is an event handler attached
            if (temp != null)
            {
                temp(this, e);
            }
        }


        #endregion


        #endregion


        /// <summary>
        /// Gibt den kompletten Dateipfad einer Node/Datei/Ordner zurück.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string getFullPathFromNode(TreeNode node)
        {

            int parentNodeLength = treeView1.Nodes[0].Text.Length;
            string sNode = node.FullPath;
            string fullPath = Path.Substring(0, Path.Length - parentNodeLength) + sNode;
            
            return fullPath;
        }
              

        /// <summary>
        /// Erstellt eine Datei und fügt sie dem FileExplorer hinzu.
        /// </summary>
        /// <param name="path">Pfad der Datei</param>
        private void createFile(string path)
        {
            System.IO.StreamWriter fs = new System.IO.StreamWriter(path);
            fs.WriteLine("");
            fs.Close();

            TreeNode node = new TreeNode();
            node.Text = System.IO.Path.GetFileName(path);
            node.ImageIndex = 2;
            node.SelectedImageIndex = 2;

            TreeNode pNode = treeView1.SelectedNode;

            pNode.Nodes.Add(node);

            MessageBox.Show(treeView1.SelectedNode.FullPath);
        }

        /// <summary>
        /// Erstellt einen Ordner und fügt sie dem FileExplorer hinzu.
        /// </summary>
        /// <param name="path">Pfad des Ordners</param>
        private void createDirectory(string path)
        {
            System.IO.Directory.CreateDirectory(path);

            TreeNode node = new TreeNode();
            node.Text = System.IO.Path.GetFileName(path);
            node.Nodes.Add("");

            TreeNode pNode = treeView1.SelectedNode;

            pNode.Nodes.Add(node);

        }

        /// <summary>
        /// Delte Funktion für Nodes in FileExplorer
        /// </summary>
        /// <param name="node">zu Löschende Node</param>
        private void deleteNode(TreeNode node)
        {


            if (System.IO.Path.GetExtension(getFullPathFromNode(treeView1.SelectedNode)) != "")
            {

                DialogResult deleteFileResult = MessageBox.Show("Willst du die Datei: " + node.Text + " wirklich löschen?", "MapMakingStudio", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (deleteFileResult == DialogResult.Yes)
                {
                    
                    System.IO.File.Delete(getFullPathFromNode(node));

                    TreeNode pNode = treeView1.SelectedNode;

                    pNode.Nodes.Remove(node);

                }
            }
            else
            {


                DialogResult deleteDireResult = MessageBox.Show("Willst du den Ordner: " + node.Text + " wirklich löschen?", "MapMakingStudio", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (deleteDireResult == DialogResult.Yes)
                {

                    System.IO.Directory.Delete(getFullPathFromNode(node), true);

                    TreeNode pNode = treeView1.SelectedNode;

                    pNode.Nodes.Remove(node);
                }
            }

        }

        /// <summary>
        /// Öffnet Node in Explorer.
        /// </summary>
        /// <param name="node">Zu öffnende Node</param>
        private void openInExplorer(TreeNode node)
        {

            string fullPath = getFullPathFromNode(node);
            if (System.IO.Path.GetExtension(fullPath) == ""){

                Process.Start(fullPath);
            }
            else
            {

                string direPath = fullPath.Substring(0, fullPath.Length - treeView1.SelectedNode.Text.Length);
                Process.Start(direPath);

            }

        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right) treeView1.SelectedNode = e.Node;
        }
        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            NodeHoverPath = getFullPathFromNode(e.Node);
        }


        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteNode(treeView1.SelectedNode);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openInExplorer(treeView1.SelectedNode);
        }
        private void dateiErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmInputDialog frmID = new frmInputDialog();

            if (frmID.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Path.GetExtension(getFullPathFromNode(treeView1.SelectedNode)) == "")
                {
                    createFile(getFullPathFromNode(treeView1.SelectedNode) + "\\" + frmID.InputText);
                }
                else
                {
                    string fullPath = getFullPathFromNode(treeView1.SelectedNode);
                    string direPath = fullPath.Substring(0, fullPath.Length - treeView1.SelectedNode.Text.Length);

                    createFile(direPath + "\\" + frmID.InputText);

                }
            }
        }
        private void ordnerErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInputDialog frmID = new frmInputDialog();

            if (frmID.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Path.GetExtension(getFullPathFromNode(treeView1.SelectedNode)) == "")
                {
                    createDirectory(getFullPathFromNode(treeView1.SelectedNode) + "\\" + frmID.InputText);
                }
                else
                {
                    string fullPath = getFullPathFromNode(treeView1.SelectedNode);
                    string direPath = fullPath.Substring(0, fullPath.Length - treeView1.SelectedNode.Text.Length);

                    createDirectory(direPath + "\\" + frmID.InputText);

                }
            }
        }

    }
}
