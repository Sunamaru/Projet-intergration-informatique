using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetIntegrationInformatique
{
    public static class Data
    {
        public static String utilisateur;
        public static bool loginOk = false;

        public static bool AccesPC1 = false;
        public static bool AccesPC2 = false;
        public static bool AccesPC3 = false;

        public static bool AccesTech = false;
        public static bool AccesAdmin = false;

        public static int page = 1;

        public static string LogsAdesse1 = "\\\\PC-TIMMY\\Users\\ttesteur\\Documents\\Supervisator2000\\logs.txt";
        public static string LogsAdesse2 = "\\\\PC-MICHEL\\Users\\msardou\\Documents\\Supervisator2000\\logs.txt";
        public static string LogsAdesse3 = "\\\\PC-ROBERT\\Users\\rredford\\Documents\\Supervisator2000\\logs.txt";
        public static string computer1 = "PC-Timmy";
        public static string computer2 = "PC-Michel";
        public static string computer3 = "PC-Robert";
        public static string domain = "SilexFR";
        public static string username = "Administrateur";

        public static string disk1size = "-";
        public static string disk1remain = "-";
        public static double DD1size = 0;
        public static double DD1remain = 0;

        public static string ram1size = "-";
        public static double memory1size = 0;
        public static string ram1percent = "-";

        public static string disk2size = "-";
        public static string disk2remain = "-";
        public static double DD2size = 0;
        public static double DD2remain = 0;

        public static string ram2size = "-";
        public static double memory2size = 0;
        public static string ram2Percent = "-";

        public static string disk3size = "-";
        public static string disk3remain = "-";
        public static double DD3size = 0;
        public static double DD3remain = 0;

        public static string ram3size = "-";
        public static double memory3size = 0;
        public static string ram3percent = "-";

        public static string rudepassword = "azerty123!";

    }
}
