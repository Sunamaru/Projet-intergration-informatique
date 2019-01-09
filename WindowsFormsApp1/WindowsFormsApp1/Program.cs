using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIntegrationInformatique
{
    static class Program
    {
        public static class Data
        {
            public static String utilisateur;
            public static bool loginOk = false;
        }     
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            if (Data.loginOk)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
