using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//dynamic binding
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // 1: 初始化邊長
            double edge = 2.3;

            // 2: 計算
            /*
            // 功能2
            //double rectangular = edge * edge;
            iMeasurement cal_rect = new rect();
            double rect_result = cal_rect.cal(edge);

            // 功能3
            //double cube = edge * edge * edge;
            iMeasurement cal_cube = new cube();
            double cube_result = cal_cube.cal(edge);
            */

            Assembly assembly;
            Type type;

            // 2.1. 找出要動態綁定(dynamic binding)的函式庫(dll)檔案位置
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select dll file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "dll files (*.*)|*.dll";
            string dll_path = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dll_path = dialog.FileName;
            }

            // 2.2. 載入函式庫(dll)檔案
            assembly = Assembly.LoadFrom(dll_path);

            // 2.3. 找出要載入的class名稱(格式: namesapce_name.class_name)
            // type = assembly.GetType("Team2.rect");
            //type = assembly.GetType(textBox1.Text);
            type = assembly.GetType(dll_path);

            // 2.4. 初始化物件
            var dynamic_object = Activator.CreateInstance(type);

            // 2.5. 初始化方法
            var dynamic_method = type.GetMethod("cal", new Type[] { typeof(double) });

            // 2.6. 呼叫函示
            var dynamic_result = dynamic_method.Invoke(dynamic_object, // 第一個是物件
                                 new object[] { edge } // 第二個是要輸入函式的參數
                                 );

            // 3: 跳出正方形面積/體積的資料
            //MessageBox.Show(String.Format("正方型面積 {0}, 正立方體面積 {1}",
            //                                 rect_result, cube_result));

            MessageBox.Show(dynamic_result.ToString());

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
