using System;
using System.Windows.Forms;

namespace PlexParser
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
            Application.Run(new Multiplex());  // Form1 is the main form to open
        }
    }
}
