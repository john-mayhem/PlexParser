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
            
            // Start the application with the Multiplex form.
            // This form is the main interface for the user.
            Application.Run(new Multiplex());
        }
    }
}