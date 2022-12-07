using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mproject_dynamic_binding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 功能1
            double edge = 2.3;

            // 功能2
            //double rectangular = edge * edge;
            iMeasurement cal_rect = new rect();
            double rect_result = cal_rect.cal(edge);

            // 功能3
            //double cube = edge * edge * edge;
            iMeasurement cal_cube = new cube();
            double cube_result = cal_cube.cal(edge);

            // 功能4
            MessageBox.Show(String.Format("正方型面積 {0}, 正立方體面積 {1}",
                                                                       rect_result, cube_result));
        }
    }

    // for 團隊一
    // for contract (契約)
    public interface iMeasurement
    {
        double cal(double edge);
    }

    // for 團隊二
    public class rect : iMeasurement
    {
        public double measurement;
        public rect()
        {
            measurement = 0;
        }
        public double cal(double i_edge)
        {
            measurement = i_edge * i_edge;
            return measurement;
        }
    }

    // for 團隊三
    public class cube : iMeasurement
    {
        public double measurement;
        public cube()
        {
            measurement = 0;
        }
        public double cal(double i_edge)
        {
            measurement = i_edge * i_edge * i_edge;
            return measurement;
        }
    }

}
