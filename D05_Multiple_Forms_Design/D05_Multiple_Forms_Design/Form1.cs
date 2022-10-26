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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 打開程式後,跳出Form2確認帳號密碼
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // 打開Form2而不會鎖定Form1
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // 打開Form2會鎖定Form1
            form2.ShowDialog();
        }

        private void pdfReaderBtn_Click(object sender, EventArgs e)
        {
            pdfReaderForm pdfForm = new pdfReaderForm();

            pdfForm.Show();
        }

        private void wordReaderBtn_Click(object sender, EventArgs e)
        {
            WordReaderForm wordReaderForm = new WordReaderForm();
            wordReaderForm.Show();
        }

        private void excelReaderBtn_Click(object sender, EventArgs e)
        {
            ExcelReaderForm excelReaderForm = new ExcelReaderForm();
            excelReaderForm.Show();
        }
    }
}
