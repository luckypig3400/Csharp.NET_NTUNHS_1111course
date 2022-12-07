using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace cl1
{
    public class Class1
    {
        private string Name;
        private int Age;
        public Class1() { Name = "name"; Age = 0; }
        public Class1(string name) { Name = name; Age = 0; }
        public Class1(string name, int age) { Name = name; Age = age; }
        public static void M1()
        {
            MessageBox.Show("靜態無參函式");
        }
        public static void M2(string name)
        {
            MessageBox.Show($"靜態帶參函式String{name}");
        }
        public static void M2(string name, int age)
        {
            MessageBox.Show($"靜態帶參函式int{name + age}");
        }
        public void M3()
        {
            MessageBox.Show($"非靜態無參函式name={Name},age={Age}");
        }
        public void M4(string name)
        {
            MessageBox.Show($"非靜態帶參函式string{name}");
        }
        public void M4(int age)
        {
            MessageBox.Show($"非靜態帶參函式int{age}");
        }
        public void M5(string name) { MessageBox.Show(name); }
    }
}
