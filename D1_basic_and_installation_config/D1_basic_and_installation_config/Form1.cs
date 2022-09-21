using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_basic_and_installation_config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloWorldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Hi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
