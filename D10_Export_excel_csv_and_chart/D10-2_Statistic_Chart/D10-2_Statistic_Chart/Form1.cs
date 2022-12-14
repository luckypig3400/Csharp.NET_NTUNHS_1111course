using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D10_2_Statistic_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawChartBTN_Click(object sender, EventArgs e)
        {
            this.chart1.Series["stocks"].Points.AddXY("1", 123);
            this.chart1.Series["stocks"].Points.AddXY("哈哈", 12);
            this.chart1.Series["stocks"].Points.AddXY("abc", 44);
            this.chart1.Series["stocks"].Points.AddXY("c#", 123);
        }
    }
}
