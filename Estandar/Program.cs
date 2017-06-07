using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Estandar
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

            Login login = new Login();
            Application.Run(login);
            if (login.credencialesCorrectos)
            {
                Application.Run(new General());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
