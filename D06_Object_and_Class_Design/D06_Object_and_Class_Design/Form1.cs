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
            // 不管是甚麼自訂變數，一切都照著合約變數(interface)儲存
            List<EM.iEM> em_list = new List<EM.iEM>();

            /*
            em_list.Add(new EM.EM_BOSS("Tom", "1992.4.5"));
            em_list.Add(new EM.EM_MANAGER("John", "1993.5.6"));
            em_list.Add(new EM.EM_ASSISTANT("Joe", "1995.6.7"));
            */

            // 使用Dependency Inject設計
            // 剝離【程式碼】與【設定檔】
            em_list.Add(
                (EM.iEM) // 契約
                Activator.CreateInstance( // 新增變數
                    Type.GetType("EM.EM_BOSS_NEW"),    // 剝離【程式碼】與【設定檔】 
                    new object[] { "Tom", "1992.4.5" } // 變數輸入值
                    )
                );

            em_list.Add(
                (EM.iEM) // 契約
                Activator.CreateInstance( // 新增變數
                    Type.GetType("EM.EM_BOSS"),  // 剝離【程式碼】與【設定檔】
                    new object[] { "Tom", "1992.4.5" } // 變數輸入值
                    )
                );
            em_list.Add(
                (EM.iEM) // 契約
                Activator.CreateInstance( // 新增變數
                    Type.GetType("EM.EM_MANAGER"), // 剝離【程式碼】與【設定檔】
                    new object[] { "John", "1993.5.6" } // 變數輸入值
                    )
                );
            em_list.Add(
                (EM.iEM) // 契約
                Activator.CreateInstance( // 新增變數
                    Type.GetType("EM.EM_ASSISTANT"),  // 變數型態
                    new object[] { "Joe", "1995.6.7" } // 變數輸入值
                    )
                );

            foreach (EM.iEM element in em_list)
            {
                element.show_log();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 範例程式碼放這裡
            // Mon_Interface mon_Cases = new Jan();

            Dictionary<int, Mon_Interface> _mon_pool =
                          new Dictionary<int, Mon_Interface>();

            _mon_pool.Add(1, new Jan());
            _mon_pool.Add(2, new Feb());
            _mon_pool.Add(3, new Mar());
            _mon_pool.Add(4, new Apr());

            string _result = string.Empty;
            int _mon = 2;
            _result = _mon_pool[_mon].Show(_mon.ToString());

            Console.WriteLine(_result);
            Console.ReadLine();

            MessageBox.Show(_result);
        }

        //step1:宣告委派型別。
        public interface Mon_Interface { string Show(string i_mon); }

        public class Jan : Mon_Interface
        {
            public string Show(string i_mon) { return $"{i_mon} Jan is 31 days"; }
        }

        public class Feb : Mon_Interface
        {
            public string Show(string i_mon) { return $"{i_mon} Feb is 28 days"; }
        }

        public class Mar : Mon_Interface
        {
            public string Show(string i_mon) { return $"{i_mon} Mar is 31 days"; }
        }
        public class Apr : Mon_Interface
        {
            public string Show(string i_mon) { return $"{i_mon} Apr is 31 days"; }
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
    // for contract (契約)
    interface iEM
    {
        // Q.10. 確認程式分工是照著契約設計(designed by contract) (Interface)
        // A.10 透過interface先向甲乙方確認程式碼符合合作契約規範【show_log()】，接著
        //         使用Generics(泛型)與Interface來建立員工pool，並一一檢查是否履約
        void show_log();
    }

    class EM_tool
    {
        // Q.6. 將員工分成boss(老闆), manager(主管), assistant (組員)
        // A.6. 使用ENUM分類
        public enum EM_type { NONE, BOSS, MANAGER, ASSISTANT };
    }

    // 主包專案: 程式不變
    abstract class Employee: iEM
    {
        //用static來計算目前累積幾個員工
        private static int current_num_of_id = 0;

        // Q.5. 禁止使用者自己改class的屬性，只能透過function來改class屬性
        // A.5. 將屬性都新增成private, function都加上public
        private int id;
        private String name;
        private String birthday;
        private EM_tool.EM_type type = EM_tool.EM_type.NONE; // cm.6.

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

        // cm.6.
        public Employee(String in_name, String in_birthday, EM_tool.EM_type in_type)
        {
            // 用static來計算目前累積幾個員工
            Employee.current_num_of_id = Employee.current_num_of_id + 1;

            this.id = Employee.current_num_of_id;
            this.name = in_name;
            this.birthday = in_birthday;
            this.type = in_type; // cm6
        }

        public override string ToString()
        {
            // Q.8. 客製化內建的ToString()當作簡介員工
            // A.8. 使用override 複寫ToString()，回傳員工簡歷
            return String.Format("id: {0}, name: {1}, birthday: {2}, type: {3} "
                       , this.id, this.name, this.birthday, this.type);
        }

        public abstract void show_log();
    }

    // 外包子專案一
    class EM_BOSS : Employee, iEM
    {
        public EM_BOSS(String in_name, String in_birthday)
                  : base(in_name, in_birthday, EM_tool.EM_type.BOSS)
        {
        }

        public override void show_log()
        {
            MessageBox.Show("I am BOSS:\n" + this.ToString(),
                "員工資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class EM_BOSS_NEW : Employee, iEM
    {
        public EM_BOSS_NEW(String in_name, String in_birthday)
                  : base(in_name, in_birthday, EM_tool.EM_type.BOSS)
        {
        }

        public override void show_log()
        {
            MessageBox.Show(" I am Boss New: " + this.ToString());
        }
    }

    // 外包子專案二
    class EM_MANAGER : Employee, iEM
    {
        public EM_MANAGER(String in_name, String in_birthday)
             : base(in_name, in_birthday, EM_tool.EM_type.MANAGER)
        {
        }

        public override void show_log()
        {
            MessageBox.Show("I am MANAGER:\n" + this.ToString(),
                "員工資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    // 外包子專案三
    class EM_ASSISTANT : Employee, iEM
    {
        public EM_ASSISTANT(String in_name, String in_birthday)
            : base(in_name, in_birthday, EM_tool.EM_type.ASSISTANT)
        {
        }

        public override void show_log()
        {
            MessageBox.Show("I am ASSISTANT:\n" + this.ToString(),
                "員工資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
