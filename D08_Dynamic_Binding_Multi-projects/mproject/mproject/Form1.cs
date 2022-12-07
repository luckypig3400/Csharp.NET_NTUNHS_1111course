using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1;
using Team2;
using Team3;

namespace mproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 功能1: 初始化邊長
            double edge = 2.3;

            // 功能2: 計算正方形面積
            //double rect_result = edge * edge;
            iMeasurement cal_rect = new rect();
            double rect_result = cal_rect.cal(edge);

            // 功能3: 計算正方體體積
            //double cube_result = edge * edge * edge;
            iMeasurement cal_cube = new cube();
            double cube_result = cal_cube.cal(edge);

            // 功能4: 跳出正方形面積與體積的資料
            MessageBox.Show(String.Format("正方型面積 {0}, 正立方體面積 {1}",
                                             rect_result, cube_result));
        }
    }

}
