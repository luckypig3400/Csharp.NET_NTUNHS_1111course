using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D04_Basic_GUI_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputDataBtn_Click(object sender, EventArgs e)
        {
            string i_input_price = priceTextBox.Text;
            string i_input_num = numTextBox.Text;
            double price = Convert.ToDouble(i_input_price);
            double num = Convert.ToDouble(i_input_num);

            richTextBox1.Text = (price * num).ToString();
        }
    }
}
