using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockBonBerger.Forms
{
    public partial class FormMain : Form
    {
        private int childFormNumber = 0;
        private Form form = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            form = new FormConnection();
            form.Icon = this.Icon;
            form.ShowDialog();
        }

        private void SmCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SmConnection_Click(object sender, EventArgs e)
        {
            form = new FormConnection();
            form.Icon = this.Icon;
            form.ShowDialog();
        }

        private void SmPiece_Click(object sender, EventArgs e)
        {
            form = new FormPiece();
            form.Icon = this.Icon;
            form.MdiParent = this;
            form.Show();
        }

        private void SmClient_Click(object sender, EventArgs e)
        {

        }

        private void SmFss_Click(object sender, EventArgs e)
        {
            form = new FormFournisseur();
            form.Icon = this.Icon;
            form.MdiParent = this;
            form.Show();
        }
    }
}
