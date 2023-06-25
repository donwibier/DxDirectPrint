using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DxPrintConnector.PrinterConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DxPrintConnector
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(false, "efa8a824-93c9-4c96-b6ec-9c864593f4da");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                MessageBox.Show("Application already started!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            finally { mutex.ReleaseMutex(); }
        }
    }
}
