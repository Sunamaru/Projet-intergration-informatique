using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;

namespace ProjetIntegrationInformatique
{
    public partial class MainForm : Form
    {
        string LogsAdesse1 = "\\\\PC-TIMMY\\Users\\ttesteur\\Documents\\Supervisator2000\\logs.txt";
        string LogsAdesse2 = "\\\\PC-MICHEL\\Users\\msardou\\Documents\\Supervisator2000\\logs.txt";
        string LogsAdesse3 = "\\\\PC-ROBERT\\Users\\rredford\\Documents\\Supervisator2000\\logs.txt";
        string computer1 = "PC-Timmy";
        string computer2 = "PC-Michel";
        string computer3 = "PC-Robert";       
        string domain = "SilexFR";
        string username = "Administrateur";

        string disk1size;
        string disk1remain;
        double DD1size;
        double DD1remain;

        string disk2size;
        string disk2remain;
        double DD2size;
        double DD2remain;

        string disk3size;
        string disk3remain;
        double DD3size;
        double DD3remain;

        string rudepassword = "azerty123!";

        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IHMload();
            UpdateIHM();
        }

        private void DiskScan()
        {
            var password = new SecureString();
            foreach (char c in rudepassword)
            {
                password.AppendChar(c);
            }
            CimCredential Credentials = new CimCredential(PasswordAuthenticationMechanism.Default, domain, username, password);

            WSManSessionOptions SessionOptions = new WSManSessionOptions();
            SessionOptions.AddDestinationCredentials(Credentials);
            CimSession Session1 = CimSession.Create(computer1, SessionOptions);
            var allVolumes1 = Session1.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Volume");
            foreach (CimInstance oneVolume1 in allVolumes1)
            {
                if (oneVolume1.CimInstanceProperties["DriveLetter"].ToString() == "DriveLetter = \"C:\"")
                {
                    disk1size = String.Format("{0}", oneVolume1.CimInstanceProperties["Capacity"].Value);
                    DD1size = Math.Round(Convert.ToDouble(disk1size) / 1073741824, 2);
                    disk1size = DD1size.ToString() + " GB";
                    disk1remain = String.Format("{0}", oneVolume1.CimInstanceProperties["FreeSpace"].Value);
                    DD1remain = Math.Round(Convert.ToDouble(disk1remain) / 1073741824, 2);
                    disk1remain = DD1remain.ToString() + " GB";
                }
                BarDD1.Maximum = (int)DD1size;
                BarDD1.Value = (int)(DD1size - DD1remain);
            }

            CimSession Session2 = CimSession.Create(computer2, SessionOptions);
            var allVolumes2 = Session2.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Volume");
            foreach (CimInstance oneVolume2 in allVolumes2)
            {
                if (oneVolume2.CimInstanceProperties["DriveLetter"].ToString() == "DriveLetter = \"C:\"")
                {
                    disk2size = String.Format("{0}", oneVolume2.CimInstanceProperties["Capacity"].Value);
                    DD2size = Math.Round(Convert.ToDouble(disk2size) / 1073741824, 2);
                    disk2size = DD2size.ToString() + " GB";
                    disk2remain = String.Format("{0}", oneVolume2.CimInstanceProperties["FreeSpace"].Value);
                    DD2remain = Math.Round(Convert.ToDouble(disk2remain) / 1073741824, 2);
                    disk2remain = DD2remain.ToString() + " GB";
                }
                BarDD2.Maximum = (int)DD2size;
                BarDD2.Value = (int)(DD2size - DD2remain);
            }

            CimSession Session3 = CimSession.Create(computer3, SessionOptions);
            var allVolumes3 = Session3.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Volume");
            foreach (CimInstance oneVolume3 in allVolumes3)
            {
                if (oneVolume3.CimInstanceProperties["DriveLetter"].ToString() == "DriveLetter = \"C:\"")
                {
                    disk3size = String.Format("{0}", oneVolume3.CimInstanceProperties["Capacity"].Value);
                    DD3size = Math.Round(Convert.ToDouble(disk3size) / 1073741824, 2);
                    disk3size = DD3size.ToString() + " GB";
                    disk3remain = String.Format("{0}", oneVolume3.CimInstanceProperties["FreeSpace"].Value);
                    DD3remain = Math.Round(Convert.ToDouble(disk3remain) / 1073741824, 2);
                    disk3remain = DD3remain.ToString() + " GB";
                }
                BarDD3.Maximum = (int)DD3size;
                BarDD3.Value = (int)(DD3size - DD3remain);
            }
        }

        private void IHMload()
        {
            this.Text = "Supervisator 2001 - " + Data.utilisateur;
            
            switch (Data.utilisateur)
            {
                case "Admin":
                    ButtonEquipement.Visible = true;
                    ButtonTickets.Visible = true;
                    ButtonProfils.Visible = true;
                    break;
                case "Tech1":
                    ButtonEquipement.Visible = true;
                    ButtonTickets.Visible = true;
                    ButtonProfils.Visible = false;
                    break;
                case "Tech2":
                    ButtonEquipement.Visible = true;
                    ButtonTickets.Visible = true;
                    ButtonProfils.Visible = false;
                    break;
                case "User1":
                    ButtonEquipement.Visible = true;
                    ButtonTickets.Visible = false;
                    ButtonProfils.Visible = false;
                    break;
                case "User2":
                    ButtonEquipement.Visible = true;
                    ButtonTickets.Visible = false;
                    ButtonProfils.Visible = false;
                    break;
                case "User3":
                    ButtonEquipement.Visible = true;
                    ButtonTickets.Visible = false;
                    ButtonProfils.Visible = false;
                    break;
                default:
                    ButtonEquipement.Visible = false;
                    ButtonTickets.Visible = false;
                    ButtonProfils.Visible = false;
                    break;
            }
        }

        private void buttonLog1_Click(object sender, EventArgs e)
        {
            labelError1.Visible = false;
            var password = new SecureString();
            foreach (char c in rudepassword)
            {
                password.AppendChar(c);
            }
            try
            {
                Process.Start("notepad.exe", LogsAdesse1, username, password, domain);
            }
            catch
            {
                labelError1.Visible = true;
            }
        }

        private void buttonLog2_Click(object sender, EventArgs e)
        {
            labelError2.Visible = false;
            var password = new SecureString();
            foreach (char c in rudepassword)
            {
                password.AppendChar(c);
            }
            try
            {
                Process.Start("notepad.exe", LogsAdesse2, username, password, domain);
            }
            catch
            {
                labelError2.Visible = true;
            }
        }

        private void buttonLog3_Click(object sender, EventArgs e)
        {
            labelError3.Visible = false;
            var password = new SecureString();
            foreach (char c in rudepassword)
            {
                password.AppendChar(c);
            }
            try
            {
                Process.Start("notepad.exe", LogsAdesse3, username, password, domain);
            }
            catch
            {
                labelError3.Visible = true;
            }
        }

        private void UpdateIHM()
        {
            if (Data.page == 1)
            {
                switch (Data.utilisateur)
                {
                    case "Admin":
                        groupPC1.Visible = true;
                        groupPC2.Visible = true;
                        groupPC3.Visible = true;
                        break;
                    case "Tech1":
                        groupPC1.Visible = true;
                        groupPC2.Visible = true;
                        groupPC3.Visible = false;
                        break;
                    case "Tech2":
                        groupPC1.Visible = false;
                        groupPC2.Visible = false;
                        groupPC3.Visible = true;
                        break;
                    case "User1":
                        groupPC1.Visible = true;
                        groupPC2.Visible = false;
                        groupPC3.Visible = false;
                        break;
                    case "User2":
                        groupPC1.Visible = false;
                        groupPC2.Visible = true;
                        groupPC3.Visible = false;
                        break;
                    case "User3":
                        groupPC1.Visible = false;
                        groupPC2.Visible = false;
                        groupPC3.Visible = false;
                        break;
                    default:
                        groupPC1.Visible = false;
                        groupPC2.Visible = false;
                        groupPC3.Visible = false;
                        break;
                }
                groupTicketEnCours.Visible = false;
                groupTicketSoumis.Visible = false;
                groupTicketsResolues.Visible = false;
                groupProfils.Visible = false;
            }

            else if (Data.page == 2)
            {
                groupPC1.Visible = false;
                groupPC2.Visible = false;
                groupPC3.Visible = false;
                groupTicketEnCours.Visible = true;
                groupTicketSoumis.Visible = true;
                groupTicketsResolues.Visible = true;
                groupProfils.Visible = false;
            }
            else if (Data.page == 3)
            {
                groupPC1.Visible = false;
                groupPC2.Visible = false;
                groupPC3.Visible = false;
                groupTicketEnCours.Visible = false;
                groupTicketSoumis.Visible = false;
                groupTicketsResolues.Visible = false;
                groupProfils.Visible = true;
            }

            DiskScan();
            labelDisk1Remain.Text = disk1remain;
            labelDisk1Total.Text = disk1size;
            labelDisk1Used.Text = "Espace occupé (" + (Math.Round(((DD1size - DD1remain) / DD1size), 2) * 100) + "%) :";
            labelDisk2Remain.Text = disk2remain;
            labelDisk2Total.Text = disk2size;
            labelDisk2Used.Text = "Espace occupé (" + (Math.Round(((DD2size - DD2remain) / DD2size), 2) * 100) + "%) :";
            labelDisk3Remain.Text = disk3remain;
            labelDisk3Total.Text = disk3size;
            labelDisk3Used.Text = "Espace occupé (" + (Math.Round(((DD3size - DD3remain) / DD3size), 2) * 100) + "%) :";
        }

        private void ButtonEquipement_Click(object sender, EventArgs e)
        {
            Data.page = 1;
            UpdateIHM();
        }

        private void ButtonTickets_Click(object sender, EventArgs e)
        {
            Data.page = 2;
            UpdateIHM();
        }

        private void ButtonProfils_Click(object sender, EventArgs e)
        {
            Data.page = 3;
            UpdateIHM();
        }
    }
}
