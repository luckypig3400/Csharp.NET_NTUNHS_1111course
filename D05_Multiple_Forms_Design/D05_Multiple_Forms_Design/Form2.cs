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
        Boolean allowCloseForm2 = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            allowCloseForm2 = true;
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
                allowCloseForm2 = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if(allowCloseForm2)
                e.Cancel = false;
            else
            {
                MessageBox.Show("您尚未登入OAO\n如要關閉整個程式，請點關閉!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Cancel = true;// 尚未登入，取消關閉
            }
        }
    }
}
