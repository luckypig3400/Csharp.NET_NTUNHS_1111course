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
            int i = 4;

            // Debug.Assert 是用在 Debug mode，在release mode中，不會執行Assert
            // i應該要等於4，否則跳出警訊
            Debug.Assert(i == 4);
            // 檢查i是等於4：會輸出 True Debug: i is not equal to 4
            Debug.WriteLine(i == 4, "Debug: i is not equal to 4");

            // Trace.Assert 是用在 Debug mode和release mode
            // i應該要等於4，否則跳出警訊
            Trace.Assert(i == 4);
            // 檢查i是等於4：會輸出 True Debug: i is not equal to 4
            Trace.WriteLine(i == 4, "Trace: i is equal to 4");

        }
    }
}
