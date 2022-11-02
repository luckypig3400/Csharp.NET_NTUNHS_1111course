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
            // 初始化變數
            EM.Employee em1 = new EM.Employee();
            EM.Employee em2 = new EM.Employee();
            EM.Employee em3 = new EM.Employee();

            em1.id = 1;
            em1.name = "Tom";
            em1.birthday = "1992.4.5";

            em2.id = 2;
            em2.name = "John";
            em2.birthday = "1993.5.6";

            em3.id = 3;
            em3.name = "Joe";
            em3.birthday = "1995.6.7";

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
        public int id;
        public String name;
        public String birthday;

        public void show_log()
        {
            MessageBox.Show(String.Format("id: {0}, name: {1}", this.id, this.name),
                "員工資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
