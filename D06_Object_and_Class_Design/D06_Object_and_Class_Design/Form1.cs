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
            /*
            EM.Employee em1 = new EM.Employee(1, "Tom", "1992.4.5");
            EM.Employee em2 = new EM.Employee(2, "John", "1993.5.6");
            EM.Employee em3 = new EM.Employee(3, "Joe", "1995.6.7");
            */
            EM.Employee em1 = new EM.Employee("Tom", "1992.4.5");
            EM.Employee em2 = new EM.Employee("John", "1993.5.6");
            EM.Employee em3 = new EM.Employee("Joe", "1995.6.7");

            em1.show_log();
            em2.show_log();
            em3.show_log();
        }
    }
}

/*
public:  任何外部類別都可不受限制存取此類別成員
private:  此類別成員只能在此類別中使用
protected: 此類別成員可在此類別及繼承此類別的子類別使用
internal:  在同一個組件中都可存取此類別成員
protected internal: 提供 protected 及 internal 二種存取方式
*/

// 專案: EM
namespace EM
{
    // 自訂變數: Employee
    class Employee
    {
        //用static來計算目前累積幾個員工
        private static int current_num_of_id = 0;

        public int id;
        public String name;
        public String birthday;

        public Employee(int in_id, String in_name, String in_birthday)
        {
            this.id = in_id;
            this.name = in_name;
            this.birthday = in_birthday;
        }

        // 多型(Polymorphism)，用不同的input來達到不同程式目的
        public Employee(String in_name, String in_birthday)
        {
            // 用static來計算目前累積幾個員工
            Employee.current_num_of_id = Employee.current_num_of_id + 1;

            this.id = Employee.current_num_of_id;
            this.name = in_name;
            this.birthday = in_birthday;
        }

        public void show_log()
        {
            MessageBox.Show(String.Format("id: {0}, name: {1}", this.id, this.name),
                "員工資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
