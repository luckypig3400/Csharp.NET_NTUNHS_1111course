using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D06_Object_and_Class_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int employee_1_id = 1;
            String employee_1_name = "Tom";
            int employee_2_id = 2;
            String employee_2_name = "John";
            int employee_3_id = 3;
            String employee_3_name = "Joe";

            MessageBox.Show(String.Format("id: {0}, name: {1}"
                                , employee_1_id, employee_1_name));
            MessageBox.Show(String.Format("id: {0}, name: {1}"
                                , employee_2_id, employee_2_name));
            MessageBox.Show(String.Format("id: {0}, name: {1}"
                                , employee_3_id, employee_3_name));
        }
    }
}
