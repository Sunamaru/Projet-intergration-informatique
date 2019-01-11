﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadUser(Data.utilisateur);
            IHMload();
            UpdateIHM();
        }

        private void loadUser(String user)
        {
            switch (Data.utilisateur)
            {
                case "Admin":
                    Data.AccesAdmin = true;
                    Data.AccesTech = true;
                    Data.AccesPC1 = true;
                    Data.AccesPC2 = true;
                    Data.AccesPC3 = true;
                    break;
                case "Tech1":
                    Data.AccesAdmin = false;
                    Data.AccesTech = true;
                    Data.AccesPC1 = true;
                    Data.AccesPC2 = true;
                    Data.AccesPC3 = false;
                    break;
                case "Tech2":
                    Data.AccesAdmin = false;
                    Data.AccesTech = true;
                    Data.AccesPC1 = false;
                    Data.AccesPC2 = false;
                    Data.AccesPC3 = true;
                    break;
                case "User1":
                    Data.AccesAdmin = false;
                    Data.AccesTech = false;
                    Data.AccesPC1 = true;
                    Data.AccesPC2 = false;
                    Data.AccesPC3 = false;
                    break;
                case "User2":
                    Data.AccesAdmin = false;
                    Data.AccesTech = false;
                    Data.AccesPC1 = false;
                    Data.AccesPC2 = true;
                    Data.AccesPC3 = false;
                    break;
                case "User3":
                    Data.AccesAdmin = false;
                    Data.AccesTech = false;
                    Data.AccesPC1 = false;
                    Data.AccesPC2 = false;
                    Data.AccesPC3 = true;
                    break;
                default:
                    Data.AccesAdmin = false;
                    Data.AccesTech = false;
                    Data.AccesPC1 = false;
                    Data.AccesPC2 = false;
                    Data.AccesPC3 = false;
                    break;
            }
        }

        private void IHMload()
        {
            this.Text = "Supervisator 2001 - " + Data.utilisateur;
            ButtonEquipement.Visible = true;
            ButtonTickets.Visible = Data.AccesTech;
            ButtonProfils.Visible = Data.AccesAdmin;
        }

        private void UpdateIHM()
        {
            if (Data.page == 1)
            {
                groupPC1.Visible = Data.AccesPC1;
                groupPC2.Visible = Data.AccesPC2;
                groupPC3.Visible = Data.AccesPC3;

                groupTicketEnCours.Visible = false;
                groupTicketSoumis.Visible = false;
                groupTicketsResolues.Visible = false;
                groupProfils.Visible = false;

                DiskScan(Data.AccesPC1, Data.AccesPC2, Data.AccesPC3);
                RamScan(Data.AccesPC1, Data.AccesPC2, Data.AccesPC3);
                CpuScan(Data.AccesPC1, Data.AccesPC2, Data.AccesPC3);
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
        }

        private void DiskScan(bool PC1, bool PC2, bool PC3)
        {
            var password = new SecureString();
            foreach (char c in Data.rudepassword)
            {
                password.AppendChar(c);
            }
            CimCredential Credentials = new CimCredential(PasswordAuthenticationMechanism.Default, Data.domain, Data.username, password);

            WSManSessionOptions SessionOptions = new WSManSessionOptions();
            SessionOptions.AddDestinationCredentials(Credentials);

            if (PC1)
            {
                CimSession Session1 = CimSession.Create(Data.computer1, SessionOptions);
                var allVolumes1 = Session1.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Volume");
                foreach (CimInstance oneVolume1 in allVolumes1)
                {
                    if (oneVolume1.CimInstanceProperties["DriveLetter"].ToString() == "DriveLetter = \"C:\"")
                    {
                        Data.disk1size = String.Format("{0}", oneVolume1.CimInstanceProperties["Capacity"].Value);
                        Data.DD1size = Math.Round(Convert.ToDouble(Data.disk1size) / 1073741824, 2);
                        Data.disk1size = Data.DD1size.ToString() + " GB";
                        Data.disk1remain = String.Format("{0}", oneVolume1.CimInstanceProperties["FreeSpace"].Value);
                        Data.DD1remain = Math.Round(Convert.ToDouble(Data.disk1remain) / 1073741824, 2);
                        Data.disk1remain = Data.DD1remain.ToString() + " GB";
                    }
                    BarDD1.Maximum = (int)Data.DD1size;
                    BarDD1.Value = (int)(Data.DD1size - Data.DD1remain);
                }
                labelDisk1Remain.Text = Data.disk1remain;
                labelDisk1Total.Text = Data.disk1size;
                labelDisk1Used.Text = "Espace occupé (" + (Math.Round(((Data.DD1size - Data.DD1remain) / Data.DD1size), 2) * 100) + "%) :";
            }

            if (PC2)
            {
                CimSession Session2 = CimSession.Create(Data.computer2, SessionOptions);
                var allVolumes2 = Session2.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Volume");
                foreach (CimInstance oneVolume2 in allVolumes2)
                {
                    if (oneVolume2.CimInstanceProperties["DriveLetter"].ToString() == "DriveLetter = \"C:\"")
                    {
                        Data.disk2size = String.Format("{0}", oneVolume2.CimInstanceProperties["Capacity"].Value);
                        Data.DD2size = Math.Round(Convert.ToDouble(Data.disk2size) / 1073741824, 2);
                        Data.disk2size = Data.DD2size.ToString() + " GB";
                        Data.disk2remain = String.Format("{0}", oneVolume2.CimInstanceProperties["FreeSpace"].Value);
                        Data.DD2remain = Math.Round(Convert.ToDouble(Data.disk2remain) / 1073741824, 2);
                        Data.disk2remain = Data.DD2remain.ToString() + " GB";
                    }
                    BarDD2.Maximum = (int)Data.DD2size;
                    BarDD2.Value = (int)(Data.DD2size - Data.DD2remain);
                }
                labelDisk2Remain.Text = Data.disk2remain;
                labelDisk2Total.Text = Data.disk2size;
                labelDisk2Used.Text = "Espace occupé (" + (Math.Round(((Data.DD2size - Data.DD2remain) / Data.DD2size), 2) * 100) + "%) :";
            }

            if (PC3)
            {
                CimSession Session3 = CimSession.Create(Data.computer3, SessionOptions);
                var allVolumes3 = Session3.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_Volume");
                foreach (CimInstance oneVolume3 in allVolumes3)
                {
                    if (oneVolume3.CimInstanceProperties["DriveLetter"].ToString() == "DriveLetter = \"C:\"")
                    {
                        Data.disk3size = String.Format("{0}", oneVolume3.CimInstanceProperties["Capacity"].Value);
                        Data.DD3size = Math.Round(Convert.ToDouble(Data.disk3size) / 1073741824, 2);
                        Data.disk3size = Data.DD3size.ToString() + " GB";
                        Data.disk3remain = String.Format("{0}", oneVolume3.CimInstanceProperties["FreeSpace"].Value);
                        Data.DD3remain = Math.Round(Convert.ToDouble(Data.disk3remain) / 1073741824, 2);
                        Data.disk3remain = Data.DD3remain.ToString() + " GB";
                    }
                    BarDD3.Maximum = (int)Data.DD3size;
                    BarDD3.Value = (int)(Data.DD3size - Data.DD3remain);
                }
                labelDisk3Remain.Text = Data.disk3remain;
                labelDisk3Total.Text = Data.disk3size;
                labelDisk3Used.Text = "Espace occupé (" + (Math.Round(((Data.DD3size - Data.DD3remain) / Data.DD3size), 2) * 100) + "%) :";
            }
        }

        private void RamScan(bool PC1, bool PC2, bool PC3)
        {
            var password = new SecureString();
            foreach (char c in Data.rudepassword)
            {
                password.AppendChar(c);
            }
            CimCredential Credentials = new CimCredential(PasswordAuthenticationMechanism.Default, Data.domain, Data.username, password);

            WSManSessionOptions SessionOptions = new WSManSessionOptions();
            SessionOptions.AddDestinationCredentials(Credentials);
            if (PC1)
            {
                CimSession Session1 = CimSession.Create(Data.computer1, SessionOptions);
                var allMemory1 = Session1.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PhysicalMemory");
                Data.memory1size = 0;
                foreach (CimInstance oneMemory1 in allMemory1)
                {
                    Data.ram1size = String.Format("{0}", oneMemory1.CimInstanceProperties["Capacity"].Value);
                    Data.memory1size += Math.Round(Convert.ToDouble(Data.ram1size) / 1073741824, 2);
                    Data.ram1size = Data.memory1size.ToString() +" GB";
                    labelRam1Size.Text = Data.ram1size;
                }
                var allUsedMemory1 = Session1.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");
                foreach (CimInstance oneUsedMemory1 in allUsedMemory1)
                {
                    Data.ram1percent = String.Format("{0}", oneUsedMemory1.CimInstanceProperties["PercentCommittedBytesInUse"].Value);
                }
                labelRam1Used.Text = Data.ram1percent + "%";
            }

            if (PC2)
            {
                CimSession Session2 = CimSession.Create(Data.computer2, SessionOptions);
                var allMemory2 = Session2.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PhysicalMemory");
                Data.memory2size = 0;
                foreach (CimInstance oneMemory2 in allMemory2)
                {
                    Data.ram2size = String.Format("{0}", oneMemory2.CimInstanceProperties["Capacity"].Value);
                    Data.memory2size += Math.Round(Convert.ToDouble(Data.ram2size) / 1073741824, 2);
                    Data.ram2size = Data.memory2size.ToString() + " GB";
                    labelRam2Size.Text = Data.ram2size;
                }
                var allUsedMemory2 = Session2.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");
                foreach (CimInstance oneUsedMemory2 in allUsedMemory2)
                {
                    Data.ram2Percent = String.Format("{0}", oneUsedMemory2.CimInstanceProperties["PercentCommittedBytesInUse"].Value);
                }
                labelRam2Used.Text = Data.ram2Percent + "%";
            }

            if (PC3)
            {
                CimSession Session3 = CimSession.Create(Data.computer3, SessionOptions);
                var allMemory3 = Session3.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PhysicalMemory");
                Data.memory3size = 0;
                foreach (CimInstance oneMemory3 in allMemory3)
                {
                    Data.ram3size = String.Format("{0}", oneMemory3.CimInstanceProperties["Capacity"].Value);
                    Data.memory3size += Math.Round(Convert.ToDouble(Data.ram3size) / 1073741824, 2);
                    Data.ram3size = Data.memory3size.ToString() + " GB";
                    labelRam3Size.Text = Data.ram3size;
                }
                var allUsedMemory3 = Session3.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");
                foreach (CimInstance oneUsedMemory3 in allUsedMemory3)
                {
                    Data.ram3percent = String.Format("{0}", oneUsedMemory3.CimInstanceProperties["PercentCommittedBytesInUse"].Value);
                }
                labelRam3Used.Text = Data.ram3percent + "%";
            }
        }

        private void CpuScan(bool PC1, bool PC2, bool PC3)
        {

        }

        private void buttonLog1_Click(object sender, EventArgs e)
        {
            labelError1.Visible = false;
            var password = new SecureString();
            foreach (char c in Data.rudepassword)
            {
                password.AppendChar(c);
            }
            try
            {
                Process.Start("notepad.exe", Data.LogsAdesse1, Data.username, password, Data.domain);
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
            foreach (char c in Data.rudepassword)
            {
                password.AppendChar(c);
            }
            try
            {
                Process.Start("notepad.exe", Data.LogsAdesse2, Data.username, password, Data.domain);
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
            foreach (char c in Data.rudepassword)
            {
                password.AppendChar(c);
            }
            try
            {
                Process.Start("notepad.exe", Data.LogsAdesse3, Data.username, password, Data.domain);
            }
            catch
            {
                labelError3.Visible = true;
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateIHM();
        }
    }
}
