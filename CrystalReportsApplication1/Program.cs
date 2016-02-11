using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrystalReportsEvaluation1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCrystalReport());
        }
    }
}
