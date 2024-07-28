using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Forms;
using POS.Model;

namespace POS
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
            DatabaseHandler.SetConnection("DESKTOP-KFIITTP", "", "waterdb", "sa", "wasi786");
            Application.Run(new frmLogin());
        }
    }
}
