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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Enabled = false;// 鎖住原來整個表單
            Form2 f2 = new Form2();// 新增一個變數f2，f2是剛剛的帳號密碼視窗
            f2.ShowDialog(); // 打開帳號密碼視窗
            while(true) // 反覆確認帳號密碼輸入正確
            {
                if(f2.check==true) // 如果f2的帳號密碼輸入正確
                {
                    // 解開 原來表單
                    this.Enabled = true;
                    // 離開確認帳號密碼的迴圈，進入倉儲系統表單
                    break; 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i_input_price = textBox1.Text;
            string i_input_num = textBox2.Text;
            double _price = Convert.ToDouble(i_input_price);
            double _num = Convert.ToDouble(i_input_num);
            double total = 0;
            total = _price * _num;

            string _radiobutton_log = "";
            if (radioButton1.Checked == true)
            {
                _radiobutton_log = "進貨";
            }
            else
            {
                _radiobutton_log = "出貨";
            }

            string sub_string = "";
            if(comboBox2.SelectedItem!=null)
            {
                sub_string= comboBox2.SelectedItem.ToString();
            }

            string _combobox_log = String.Format("{0} {1}",comboBox1.SelectedItem.ToString(), sub_string);

            richTextBox1.Text = String.Format("{0} : {1} {2} "
                , _price * _num, _radiobutton_log, _combobox_log);

            DataGridViewRowCollection rows = dataGridView1.Rows;
            DateTime date = DateTime.Now; // 現在時間
            rows.Add(new Object[] { "", date.ToString("yyyy/MM/dd HH:mm:ss")
                  , _radiobutton_log, _combobox_log, _price, _num, _price * _num });

        }

        private void 關於我ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是關於我");
        }

        private void second_combo(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox2.Items.Clear();
            
            if(comboBox1.SelectedItem.ToString()=="繃帶")
            {
                comboBox2.Items.Add("大繃帶");
                comboBox2.Items.Add("小繃帶");
            }
            else if (comboBox1.SelectedItem.ToString() == "口罩")
            {
                comboBox2.Items.Add("成人口罩");
                comboBox2.Items.Add("小孩口罩");
            }
        }


    }
}
