using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSFileExplorer
{
    public partial class frmInputDialog : Form
    {
        public frmInputDialog()
        {
            InitializeComponent();
        }

        #region Move Form

        private Point mouseposition;

        private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseposition.X, mouseposition.Y);
                Location = mousePos;
            }
        }

        private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposition = new Point(-e.X, -e.Y);
        }

        #endregion


        public string InputText { get; private set; }

        private void bErstellen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
          //  Close();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_OnValueChanged(object sender, EventArgs e)
        {
            InputText = tbName.Text;
        }
    }
}
