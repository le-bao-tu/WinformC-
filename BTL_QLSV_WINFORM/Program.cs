using System;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new FrmMain());
            //Application.Run(new FrmDSSV());
            //Application.Run(new FrmDSGV());
            //Application.Run(new FrmDSMH());
            Application.Run(new FrmLogin());
        }
    }
}