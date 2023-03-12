using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D13_CrossLanguageIntegration_Csharp_Python_
{
    public partial class Form1 : Form
    {
        System.Threading.Thread thread1, thread2;
        System.Diagnostics.Process p1, p2;
        string script_path_1;
        string script_args_1;
        string script_path_2;
        string script_args_2;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadPythonScriptBTN_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "%USERPROFILE%";
            openFileDialog.Filter = "python files (*.py)|*.py|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }
            richTextBox1.Text = filePath;
        }

        private void runPythonScriptBTN_Click(object sender, EventArgs e)
        {
            script_path_1 = @richTextBox1.Text;
            script_args_1 = " this is argc ";
            richTextBox2.Text = "";
            thread1 = new System.Threading.Thread(threadmethod);
            thread1.Start();
        }

        private void stopPythonScriptBTN_Click(object sender, EventArgs e)
        {
            if (!p1.HasExited)
            {
                p1.Kill();
                thread1.Abort();
            }
        }

        private void threadmethod()
        {
            RunPythonScript(script_path_1, script_args_1);
        }

        private void threadmethod2()
        {

            RunPythonScript2(script_path_2, script_args_2);
        }

        public void RunPythonScript(string script_path, string script_args)
        {
            p1 = new System.Diagnostics.Process();

            //沒有配環境變數的話，需要指定python.exe的絕對路徑
            p1.StartInfo.FileName = "python.exe";
            string sArguments = " -u " + script_path + " " + script_args;

            sArguments += " ";

            p1.StartInfo.Arguments = sArguments;
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.RedirectStandardInput = true;
            p1.StartInfo.RedirectStandardError = true;
            p1.StartInfo.CreateNoWindow = true;

            p1.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(OutputHandler);
            p1.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(OutputHandler_Err);

            p1.Start();

            // Asynchronously read the standard output of the spawned process. 
            // This raises OutputDataReceived events for each line of output.
            p1.BeginOutputReadLine();

            p1.WaitForExit();
        }

        public void RunPythonScript2(string script_path, string script_args)
        {

            p2 = new System.Diagnostics.Process();

            //沒有配環境變數的話，需要指定python.exe的絕對路徑
            p2.StartInfo.FileName = "python.exe";
            string sArguments = script_path + " " + script_args;

            sArguments += " ";

            p2.StartInfo.Arguments = sArguments;
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.RedirectStandardInput = true;
            p2.StartInfo.RedirectStandardError = true;
            p2.StartInfo.CreateNoWindow = true;

            p2.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(OutputHandler2);

            p2.Start();

            // Asynchronously read the standard output of the spawned process.
            // This raises OutputDataReceived events for each line of output.
            p2.BeginOutputReadLine();

            p2.WaitForExit();
        }

        private void OutputHandler(object sendingProcess, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                BeginInvoke(new MethodInvoker(() =>
                {

                    this.ShowLog(outLine.Data);


                }));
            }
        }

        private void ShowLog(string i_input)
        {
            richTextBox2.Text += i_input;
        }

        private void loadPythonScript2BTN_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "python files (*.py)|*.py|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }
            richTextBox3.Text = filePath;
        }

        private void runPythonScript2BTN_Click(object sender, EventArgs e)
        {
            script_path_2 = @richTextBox3.Text;
            script_args_2 = " this is argc ";
            richTextBox4.Text = "";
            thread2 = new System.Threading.Thread(threadmethod2);
            thread2.Start();
        }

        private void stopPythonScript2BTN_Click(object sender, EventArgs e)
        {
            if (!p2.HasExited)
            {
                p2.Kill();
                thread2.Abort();
            }
        }

        private void OutputHandler_Err(object sendingProcess, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                BeginInvoke(
                    new MethodInvoker(() =>
                    {
                        this.ShowLog_Err(outLine.Data);
                    }));
            }
        }

        private void OutputHandler2(object sendingProcess, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                BeginInvoke(new MethodInvoker(() => {
                    this.ShowLog2(outLine.Data);
                }));
            }
        }

        private void ShowLog_Err(string i_input)
        {
            richTextBox1.Text += i_input + "\n";
        }

        private void ShowLog2(string i_input)
        {
            richTextBox4.Text += i_input;
        }

    }
}
