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

        public static void test()
        {
            Assembly assembly;
            Type type;

            string path = @"G:\Base\SelfBasic\cl1\bin\Debug\cl1.dll";
            assembly = Assembly.LoadFrom(path);
            //獲取程式集例項中具有指定名稱的Type物件
            type = assembly.GetType("cl1.Class1");
            //獲取Class1物件
            var C1 = Activator.CreateInstance(type);//建構函式public Class1() 
            var C2 = Activator.CreateInstance(type, "string");//建構函式public Class1(string name) 

            //建構函式public Class1(string name,int age)
            var C3 = Activator.CreateInstance(type, "string", 123);
            //獲取方法
            //方法名M1在Class1類中沒有過載，獲取明確 方法為私有或不存在時返回null
            var m1 = type.GetMethod("M1");
            //執行m1 M1函式為靜態的，且無參，Invoke中引數可為null
            var val1 = m1.Invoke(null, null);

            //獲取public static void M2(string name)
            var m2 = type.GetMethod("M2", new Type[] { typeof(string) });
            var val2 = m2.Invoke(null, new object[] { "str" });//執行m2

            //獲取public static void M2(string name, int age)
            var m3 = type.GetMethod("M2", new Type[] { typeof(string), typeof(int) });
            var val3 = m3.Invoke(null, new object[] { "str", 124 });//執行m3

            //非靜態函式的獲取及呼叫
            var m4 = type.GetMethod("M3");
            var val4 = m4.Invoke(C1, null);
            val4 = m4.Invoke(C2, null);
            val4 = m4.Invoke(C3, null);

            var m5 = type.GetMethod("M4", new Type[] { typeof(string) });
            var val5 = m5.Invoke(C1, new object[] { "dtr" });
            val5 = m5.Invoke(C2, new object[] { "dtr" });
            val5 = m5.Invoke(C3, new object[] { "dtr" });

            var m6 = type.GetMethod("M4", new Type[] { typeof(int) });
            var val6 = m6.Invoke(C1, new object[] { 225 });
            val6 = m6.Invoke(C2, new object[] { 225 });
            val6 = m6.Invoke(C3, new object[] { 225 });
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
