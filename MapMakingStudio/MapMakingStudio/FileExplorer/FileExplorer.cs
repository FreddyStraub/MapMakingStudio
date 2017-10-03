using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapMakingStudio.FileExplorer
{
    public class FileExplorer
    {

        string direpath;

        /// <summary>
        /// Erstellt die Grundstruktur
        /// </summary>
        /// <param name="treeView">Zu befüllendes TreView-Control</param>
        /// <param name="direpath">Rootpfad</param>
        /// <returns></returns>
        public bool CreateTree(TreeView treeView, string direpath)
        {

            this.direpath = direpath;

            bool returnValue = false;


            try
            {

                TreeNode pdire = new TreeNode();
                pdire.Text = Path.GetFileName(direpath);
                pdire.Tag = "main";
                pdire.Nodes.Add("");
                treeView.Nodes.Add(pdire);
                returnValue = true;

            }
            catch (Exception ex)
            {
                returnValue = false;
            }

            return returnValue;
        }

        /// <summary>
        /// Listet die Nodes auf
        /// </summary>
        /// <param name="parentNode">Übergeordnete parentNode</param>
        /// <returns></returns>
        public TreeNode EnumerateDirectory(TreeNode parentNode)
        {
            string direpathWithOutparent = direpath.Replace(Path.GetFileName(direpath), "");

            DirectoryInfo rootDir = new DirectoryInfo(direpathWithOutparent + parentNode.FullPath + "\\");

            try
            {

                parentNode.Nodes[0].Remove();
                foreach (DirectoryInfo dir in rootDir.GetDirectories())
                {

                    TreeNode node = new TreeNode();
                    node.Text = dir.Name;
                    node.Nodes.Add("");
                    parentNode.Nodes.Add(node);
                }
                //Fill files
                foreach (FileInfo file in rootDir.GetFiles())
                {
                    TreeNode node = new TreeNode();
                    node.Text = file.Name;
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                    parentNode.Nodes.Add(node);
                }

            }
            catch { }

            return parentNode;

        }

    }
}
