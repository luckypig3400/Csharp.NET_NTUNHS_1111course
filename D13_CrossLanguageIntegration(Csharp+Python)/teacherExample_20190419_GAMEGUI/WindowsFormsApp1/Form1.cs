using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        private string dbPath =  Application.StartupPath ;
        private int timer_interval = 1000; // 每秒檢查一次資料庫
        private double interval = 100;

        Dictionary<string, Case_Setting> cases = new Dictionary<string, Case_Setting>();

        private DateTime tick1, tick2;
        public Form1()
        {
            InitializeComponent();
            InitializeCases();
            InitializeChart();
        }


        private void InitializeCases()
        {
            this.cases.Add("Case1", new Case_Setting("case1_log"));
            this.cases.Add("Case2", new Case_Setting("case2_log"));
            this.cases.Add("Case3", new Case_Setting("case3_log"));
            this.cases.Add("Case4", new Case_Setting("case4_log"));

        }


        private void InitializeChart()
        {
            //chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;

            chart1.ChartAreas[0].AxisY.Maximum = 110;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Interval = 20;
            chart1.ChartAreas[0].AxisY.Title = "%";
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
           
            chart1.Series["Case1"].BorderWidth = 4;
            chart1.Series["Case2"].BorderWidth = 4;
            chart1.Series["Case3"].BorderWidth = 4;
            chart1.Series["Case4"].BorderWidth = 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            exec_case("Case1", textBoxCase1.Text, textBoxInterval.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //選擇檔案路徑
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.textBoxCase1.Text = file.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick2 = DateTime.Now;
            TimeSpan ts = tick2 - tick1;
            label_elpased_time.Text = ts.ToString("dd':'hh':'mm':'ss");

            if ( ts.Seconds % Case_Setting.update_rate == 0 )
            { 
                this.update_chart("Case1");
                this.update_chart("Case2");
                this.update_chart("Case3");
                this.update_chart("Case4");
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //選擇檔案路徑
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.textBoxInterval.Text = file.FileName;
        }

        // training start
        private void button5_Click(object sender, EventArgs e)
        {
            exec_case("Case2", textBoxCase2.Text, textBoxInterval.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stop_case("Case2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.reset_case("Case1");
        }
        private void set_caseDB(string i_case_name)
        {
            string _log_name = this.cases[i_case_name].log_name;
            string _full_log_name = this.cases[i_case_name].log_path + this.cases[i_case_name].dbfile;

            bool _is_exist_db = File.Exists(_full_log_name);
            Console.WriteLine("open DB " + _full_log_name);
            if (_is_exist_db)
            {
                this.connect_db(i_case_name);
            }
            else
            {
                Console.WriteLine("error in set_caseDB");
                this.reset_caseDB(i_case_name);
            }

        }
        private void reset_caseDB(string i_case_name)
        {
            string _log_name = this.cases[i_case_name].log_name;
            string _full_log_name = this.cases[i_case_name].log_path + this.cases[i_case_name].dbfile;

            this.drop_db(i_case_name, _full_log_name);
            this.connect_db(i_case_name, false);
            this.drop_table(i_case_name, _log_name);
            this.close_db(i_case_name);
            this.connect_db(i_case_name);
        }

        private void reconnect_caseDB(string i_case_name)
        {
            this.connect_db(i_case_name);
        }

        private void close_db(string i_case_name)
        {
               this.cases[i_case_name].sqlite_connect.Close();
        }
        private void connect_db(string i_case_name, bool is_read_only=true)
        {
            if (is_read_only)
            {
                this.cases[i_case_name].sqlite_connect = new SQLiteConnection("Data source=" + this.cases[i_case_name].log_path + this.cases[i_case_name].dbfile + " ; Read Only=True ");
                this.cases[i_case_name].sqlite_connect.Open();// Open
            }
            else
            {
                this.cases[i_case_name].sqlite_connect = new SQLiteConnection("Data source=" + this.cases[i_case_name].log_path + this.cases[i_case_name].dbfile + " ");
                this.cases[i_case_name].sqlite_connect.Open();// Open
            }

        }

        private void drop_db(string i_case_name, string _full_log_name)
        {
            // drop db
            if (this.cases[i_case_name].sqlite_connect == null)
            {
                if (System.IO.File.Exists(_full_log_name))
                {
                    System.IO.File.Delete(_full_log_name);
                }
            }
            else if (this.cases[i_case_name].sqlite_connect.State == ConnectionState.Open)
            {
                this.cases[i_case_name].sqlite_datareader.Close();
                this.cases[i_case_name].sqlite_cmd.Dispose();
                this.cases[i_case_name].sqlite_connect.Close();

                GC.Collect();
                GC.WaitForPendingFinalizers();

                //SQLiteConnection.ClearAllPools();
                if (System.IO.File.Exists(_full_log_name))
                {
                    System.IO.File.Delete(_full_log_name);
                }

            }
        }

        private void drop_table(string i_case_name, string i_log_name)
        {
            string sql = "";
            sql = @"DROP TABLE IF EXISTS log ;";
            sql += @"CREATE TABLE  IF NOT EXISTS log (     seq	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,     timestamp	INTEGER,     reward	INTEGER     );";

            this.cases[i_case_name].sqlite_cmd = new SQLiteCommand(sql, this.cases[i_case_name].sqlite_connect);
            this.cases[i_case_name].sqlite_datareader = this.cases[i_case_name].sqlite_cmd.ExecuteReader();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.reset_case("Case2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //選擇檔案路徑
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.textBoxCase2.Text = file.FileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //選擇檔案路徑
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.textBoxCase3.Text = file.FileName;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dbPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stop_case("Case1");
        }


        private void Button11_Click(object sender, EventArgs e)
        {
            this.reset_case("Case3");
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            this.reset_case("Case4");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            stop_case("Case3");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            stop_case("Case4");
        }

        private void Button13_Click(object sender, EventArgs e)
        {

           exec_case("Case3", textBoxCase3.Text, textBoxInterval.Text);

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            exec_case("Case4", textBoxCase4.Text, textBoxInterval.Text);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            //選擇檔案路徑
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.textBoxCase4.Text = file.FileName;
        }

        private void update_chart(string i_casename)
        {
            string _case_name = i_casename;
            if (this.cases[_case_name].enable)
            {
                string sql = "";
                string _log_name = this.cases[_case_name].log_name;
                // Set the caption to the current time.  
                double reward = 5;
                sql = @"select ((seq / " + interval + ") * " + interval + " + " + interval + ") as last_seq, count(*) from log where reward > "+ reward + " AND seq >= " + this.cases[_case_name].seq + " AND seq < (SELECT (seq / " + interval + " * " + interval + ") FROM log ORDER BY seq DESC LIMIT 1 ) group by(seq/ " + interval + ")*" + interval + "-" + interval + " order by 1";

                this.cases[_case_name].sqlite_cmd = new SQLiteCommand(sql, this.cases[_case_name].sqlite_connect);
                
                // https://stackoverflow.com/questions/53270520/how-to-know-which-process-is-responsible-for-a-operationalerror-database-is-lo/53470118#53470118
                // connect to db
                this.cases[_case_name].sqlite_datareader = this.cases[_case_name].sqlite_cmd.ExecuteReader();

                while (this.cases[_case_name].sqlite_datareader.Read())
                {
                    double _log = Convert.ToDouble(this.cases[_case_name].sqlite_datareader[1]);
                    _log = _log / Convert.ToDouble(interval) * 100.0;
                    this.chart1.Series[_case_name].Points.AddY(_log);
                    //MessageBox.Show(sqlite_datareader[1].ToString());
                    this.cases[_case_name].seq = Convert.ToDouble(this.cases[_case_name].sqlite_datareader[0]);
                }
            }

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            this.interval = Convert.ToDouble(textBoxInterval.Text);
            this.cases["Case1"].seq = 1;
            this.chart1.Series["Case1"].Points.Clear();
            this.cases["Case2"].seq = 1;
            this.chart1.Series["Case2"].Points.Clear();
            this.cases["Case3"].seq = 1;
            this.chart1.Series["Case3"].Points.Clear();
            this.cases["Case4"].seq = 1;
            this.chart1.Series["Case4"].Points.Clear();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string _test = textBoxCase1.Text;
            string _ext = "";

            _ext = Path.GetExtension(_test);
            if (_ext.Equals(".db"))
            {
                MessageBox.Show("this is db :" + _ext + " == " + _test);
            }
            else
            {

                MessageBox.Show("this is not db :" + _ext + " == " + _test);
            }
        }

        // pplong start

        // thread passing message
        // https://learn.microsoft.com/zh-tw/dotnet/standard/threading/creating-threads-and-passing-data-at-start-time#passing-data-to-threads

        // pplong end
        private void exec_case(string i_case_name, string _program_path, string i_interval)
        {
            

            if (this.cases[i_case_name].enable || _program_path.Equals("")) return;

            string _ext = Path.GetExtension(_program_path);

            if (_ext.Equals(".py"))
            {
                string script_path = _program_path;
                cases[i_case_name].set_log_path(script_path);
                interval = Convert.ToDouble(i_interval);
                richTextBox_MSG.Text = "";

                this.cases[i_case_name].program_path = " python.exe ";
                this.cases[i_case_name].program_argu = script_path + " " + cases[i_case_name].log_name + " " + cases[i_case_name].log_path; ;
                MessageBox.Show(this.cases[i_case_name].program_argu);

                //
                this.cases[i_case_name].thread= new System.Threading.Thread(this.cases[i_case_name].threadmethod);
                this.cases[i_case_name].p = new System.Diagnostics.Process();
                this.cases[i_case_name].p.StartInfo.FileName = this.cases[i_case_name].program_path;

                this.cases[i_case_name].p.StartInfo.Arguments = this.cases[i_case_name].program_argu;
                this.cases[i_case_name].p.StartInfo.UseShellExecute = false;
                this.cases[i_case_name].p.StartInfo.RedirectStandardOutput = true;
                this.cases[i_case_name].p.StartInfo.RedirectStandardInput = true;
                this.cases[i_case_name].p.StartInfo.RedirectStandardError = true;
                this.cases[i_case_name].p.StartInfo.CreateNoWindow = true;

                // for debug
                // python 會輸出到右邊的debug視窗
                //this.cases[i_case_name].p.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(OutputHandler);

                this.cases[i_case_name].thread.Start();


                // timer
                // https://ithelp.ithome.com.tw/articles/10195452
                // http://cs0.wikidot.com/timerdemo
                
                timer1.Interval = timer_interval; // 設定每秒觸發一次
                timer1.Enabled = true;
                this.cases[i_case_name].enable = true;
                
                set_caseDB(i_case_name);
                tick1 = DateTime.Now;
                tick2 = DateTime.Now;
                label_start_time.Text = tick1.ToString("yyyy/MM/dd HH:mm:ss");
                
            }
            else if (_ext.Equals(".db"))
            {
                this.cases[i_case_name].enable = true;

                cases[i_case_name].set_db(_program_path);
                this.reconnect_caseDB(i_case_name);
                //MessageBox.Show(cases[i_case_name].log_path + cases[i_case_name].dbfile); 


                interval = Convert.ToDouble(i_interval);

                // timer
                // https://ithelp.ithome.com.tw/articles/10195452
                // http://cs0.wikidot.com/timerdemo

                timer1.Interval = timer_interval; // 設定每秒觸發一次

                
                timer1.Enabled = true;

                tick1 = DateTime.Now;
                tick2 = DateTime.Now;
                label_start_time.Text = tick1.ToString("yyyy/MM/dd HH:mm:ss");
                label_end_time.Text = tick1.ToString("--");
                
            }

        }
        private void reset_case(string i_case_name)
        {
            this.chart1.Series[i_case_name].Points.Clear();
            this.cases[i_case_name].reset();
            this.reset_caseDB(i_case_name);
        }

        private void stop_case(string i_case_name)
        {
            this.cases[i_case_name].enable = false;

            string _test = textBoxCase1.Text;
            string _ext = "";

            _ext = Path.GetExtension(_test);
            if (_ext.Equals(".py"))
            {
                //string ProcessName = "python";//換成想要結束的進程名字
                //Process[] MyProcess = Process.GetProcessesByName(ProcessName);
                //MyProcess[0].Kill();
                this.cases[i_case_name].p.Kill();

                if (!this.cases[i_case_name].p.HasExited)
                {
                    this.cases[i_case_name].p.Kill();
                    this.cases[i_case_name].thread.Abort();
                }

            }
            if (_ext.Equals(".db"))
            {
            }

            tick2 = DateTime.Now;
            label_end_time.Text = tick2.ToString("yyyy/MM/dd HH:mm:ss");
            timer1.Enabled = false;
        }

        private void OutputHandler(object sendingProcess, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                BeginInvoke(new MethodInvoker(() => {

                    this.ShowLog(outLine.Data);


                }));
            }
        }

        private void ShowLog(string i_input)
        {
            richTextBox_MSG.Text += i_input;
        }
    }

    class Case_Setting
    {
        public string log_name;
        public string log_path;
        public string program_path;
        public string program_argu;

        public bool enable;
        public string dbfile ;
        public SQLiteConnection sqlite_connect;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public double seq;
        public static int update_rate = 5;

        public System.Threading.Thread thread;
        public Process p;

        public Case_Setting(string i_log_name, bool i_enable = false)
        {
            this.log_path = Application.StartupPath;

            this.log_name = i_log_name;
            this.enable = i_enable;
            this.set_db();
            this.seq = 1;
        }
        
        public void set_db()
        {
            this.dbfile = @"\" + this.log_name + ".db";
        }

        public void set_db(string i_db_name)
        {
            
            this.log_name = Path.GetFileNameWithoutExtension(i_db_name);
            this.log_path= Path.GetDirectoryName(i_db_name);
            this.dbfile = @"\" + Path.GetFileName(i_db_name);
        }

        public void reset()
        {
            this.seq = 1;
        }

        public void set_log_path(string i_exec_program_file)
        {
            this.log_path= Path.GetDirectoryName(i_exec_program_file);

        }

        public void threadmethod()
        {

            RunPythonScript(program_path, program_argu);
        }
        public void RunPythonScript(string script_name, string script_args)
        {


            this.p.Start();

            // Asynchronously read the standard output of the spawned process. 
            // This raises OutputDataReceived events for each line of output.
            this.p.BeginOutputReadLine();

            this.p.WaitForExit();


        }
    }

}
