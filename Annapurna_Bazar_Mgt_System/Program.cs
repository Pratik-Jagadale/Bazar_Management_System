using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using APMS;
using Saii_Carving_Shop_Management_System;
using Annapurna_Bazar_Mgt_System.Report;

namespace Annapurna_Bazar_Mgt_System
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
            Application.Run(new Welcome());
        }
    }
}
