using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 需要加這一行
using ExcelDataReader;

namespace D05_Multiple_Forms_Design
{
    public partial class ExcelReaderForm : Form
    {
        public ExcelReaderForm()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void readExcelBtn_Click(object sender, EventArgs e)
        {
            // 1. 找出excel檔案位置
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select excel file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "excel files(*.*)| *.xlsx";
            string excel_path = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                excel_path = dialog.FileName;
            }
            textBox1.Text = excel_path;

            // 2. 打開excel檔
            var stream = System.IO.File.Open(excel_path,
            System.IO.FileMode.Open,
            System.IO.FileAccess.Read);
            ExcelDataReader.IExcelDataReader reader =
                ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };
            DataSet result = reader.AsDataSet(conf);
            tableCollection = result.Tables;
            comboBox1.Items.Clear();
            foreach (DataTable table in tableCollection)
            {
                comboBox1.Items.Add(table.TableName);//add sheet to combobox}
            }
        }
    }
}
