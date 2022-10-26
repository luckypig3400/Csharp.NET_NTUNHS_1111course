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
    public partial class ThreeIn1DocsReaderForm : Form
    {
        public ThreeIn1DocsReaderForm()
        {
            InitializeComponent();
        }

        private void 打開PDF閱讀器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfReaderForm pdfReader_mdi_child = new pdfReaderForm();
            pdfReader_mdi_child.MdiParent = this;
            pdfReader_mdi_child.Show();
        }

        private void 打開Word閱讀器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordReaderForm wordReader_mdi_child = new WordReaderForm();
            wordReader_mdi_child.MdiParent = this;
            wordReader_mdi_child.Show();
        }

        private void 打開Excel閱讀器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReaderForm excelReader_mdi_child = new ExcelReaderForm();
            excelReader_mdi_child.MdiParent = this;
            excelReader_mdi_child.Show();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
