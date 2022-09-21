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

        private void practice1Btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pen = 23;
            double watch = 200.2;
            double landPrice = rnd.NextDouble() * 100;
            string log = String.Format(
             "一枝筆賣{0}元，一支錶要價{1}元，隨機估計大安區每坪地價為{2}萬元",
             pen, watch, landPrice);
            MessageBox.Show(log);
        }
    }
}
