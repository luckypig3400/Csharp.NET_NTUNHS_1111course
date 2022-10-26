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
    public partial class MdiFormSub2 : Form
    {
        public MdiFormSub2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是MDI範例的子視窗2");
        }
    }
}
