using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace D07_Debug_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;

            // 計算1+2+3+4+5+6+7+8+9+10=?
            for (int i = 1; i < 10; i = i + 1)
            {
                sum = sum + i;
            }
            Debug.Assert(sum == 55);
            Debug.WriteLine(sum == 55, "Result: sum is not equal to 55");

            // 應該會跑出 55, 怎麼跑出了 45呢?
            MessageBox.Show(sum.ToString());
        }
    }
}
