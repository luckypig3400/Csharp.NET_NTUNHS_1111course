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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();// 關閉form2

            // 關閉整個Application
            System.Environment.Exit(0);
        }

        private void logintBtn_Click(object sender, EventArgs e)
        {
            String pwd = "1234";
            if(passwordTextBox.Text == pwd)
            {
                MessageBox.Show("登入成功", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
