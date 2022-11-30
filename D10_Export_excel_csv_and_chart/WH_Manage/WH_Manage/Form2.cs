using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WH_Manage
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

        }

        public bool check = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string userid = "test";
            string passwd = "1234";
            if( textBox1.Text.Equals(userid) && textBox2.Text.Equals(passwd))
            {
                check = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
