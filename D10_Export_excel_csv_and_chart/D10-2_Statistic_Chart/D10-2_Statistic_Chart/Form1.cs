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

        private void exportImageBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.FileName = "Export_Chart1_JPG";
            save.Filter = "*.jpg|*.jpg";
            if (save.ShowDialog() != DialogResult.OK) return;

            chart1.SaveImage(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
