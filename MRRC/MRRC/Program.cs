using MRRC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRRC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if the file structure is valid, otherwise create it
            // Running in a thread so the UI can render without any lag.
            new Thread(delegate () { FileUtil.InitFileStructure(); }).Start();

            // Run the app
            Application.Run(new MainWindow());
        }

        
    }
}
