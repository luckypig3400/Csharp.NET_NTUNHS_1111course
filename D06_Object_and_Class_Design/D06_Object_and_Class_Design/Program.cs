using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D06_Object_and_Class_Design
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // high dpi start
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            // high dpi end

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // high dpi start
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();
        // high dpi end
    }
}
