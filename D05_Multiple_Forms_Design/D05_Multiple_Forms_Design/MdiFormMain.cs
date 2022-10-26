using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D05_Multiple_Forms_Design
{
    public partial class MdiFormMain : Form
    {
        public MdiFormMain()
        {
            InitializeComponent();
        }

        private void mDI子視窗1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormSub1 mdi_child_1 = new MdiFormSub1();
            mdi_child_1.MdiParent = this;
            mdi_child_1.Show();
        }

        private void mDI子視窗2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiFormSub2 mdi_child_2 = new MdiFormSub2();
            mdi_child_2.MdiParent = this;
            mdi_child_2.Show();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
