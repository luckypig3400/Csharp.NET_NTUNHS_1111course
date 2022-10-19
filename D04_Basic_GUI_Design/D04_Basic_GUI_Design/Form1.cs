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

            string radioBtnLog = "";
            if (radioButton1.Checked == true)
            {
                radioBtnLog = "進貨";
            }
            else
            {
                radioBtnLog = "出貨";
            }

            string comboBoxLog = comboBox1.SelectedItem.ToString();

            richTextBox1.Text = String.Format("總金額:{0} {1} {2}",
                price * num, radioBtnLog, comboBoxLog
            );

            DataGridViewRowCollection rows = dataGridView1.Rows;
            DateTime currentDateTime = DateTime.Now; //現在時間
            rows.Add(new Object[] {"", currentDateTime.ToString("yyyy/MM/dd HH:mm:ss")
                , radioBtnLog, comboBoxLog, price, num, price * num});
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is about!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
