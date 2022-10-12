using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2_basicSyntax_and_Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p1BtnBMI_Click(object sender, EventArgs e)
        {
            double weight = 76.9;
            double height = 1.69;
            double bmi = weight / (height * height);
            DateTime today = DateTime.Now;

            string log = String.Format(
                "今天是{0}, 我的BMI為{1}",
                today.ToString("yyyy-MM-dd"), bmi);
            MessageBox.Show(log, "練習1:我的BMI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void p2BtnMonth_Click(object sender, EventArgs e)
        {
            Random randomMonth = new Random();
            int month = randomMonth.Next(1, 12+1);

            if (month == 1)
                MessageBox.Show("1月有31天");
            else if(month == 2)
                MessageBox.Show("2月有28天");
            else if(month == 3)
                MessageBox.Show("3月有31天");
            else if (month == 4)
                MessageBox.Show("4月有30天");
            else if (month == 5)
                MessageBox.Show("5月有31天");
            else if (month == 6)
                MessageBox.Show("6月有30天");
            else if (month == 7)
                MessageBox.Show("7月有31天");
            else if (month == 8)
                MessageBox.Show("8月有31天");
            else if (month == 9)
                MessageBox.Show("9月有30天");
            else if (month == 10)
                MessageBox.Show("10月有31天");
            else if (month == 11)
                MessageBox.Show("11月有30天");
            else if (month == 12)
                MessageBox.Show("12月有31天");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Go Go~", "Come on!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
