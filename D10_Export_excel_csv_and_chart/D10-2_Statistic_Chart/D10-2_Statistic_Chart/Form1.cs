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

        private void exportExcelBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.FileName = "Export_Chart_Data";
            save.Filter = "*.xlsx|*.xlsx";
            if (save.ShowDialog() != DialogResult.OK) return;

            // Excel 物件
            Microsoft.Office.Interop.Excel.Application xls = null;
            try
            {
                xls = new Microsoft.Office.Interop.Excel.Application();
                // Excel WorkBook
                Microsoft.Office.Interop.Excel.Workbook book = xls.Workbooks.Add();
                //Excel.Worksheet Sheet = (Excel.Worksheet)book.Worksheets[1];
                Microsoft.Office.Interop.Excel.Worksheet Sheet = xls.ActiveSheet;

                // 把資料塞進 Excel 內
                // 標題
                Sheet.Cells[1, 1] = "標籤";
                Sheet.Cells[1, 2] = "數量";

                // 內容
                for (int k = 0; k < this.chart1.Series["stocks"].Points.Count; k++)
                {
                    Sheet.Cells[k + 2, 1] = this.chart1.Series["stocks"].Points[k].AxisLabel.ToString();
                    Sheet.Cells[k + 2, 2] = this.chart1.Series["stocks"].Points[k].YValues[0].ToString();
                }

                // 儲存檔案
                book.SaveAs(save.FileName);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                xls.Quit();
            }
        }
    }
}
