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
    }
}
