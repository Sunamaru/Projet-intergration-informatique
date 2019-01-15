namespace ProjetIntegrationInformatique
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLog1 = new System.Windows.Forms.Button();
            this.buttonLog3 = new System.Windows.Forms.Button();
            this.buttonLog2 = new System.Windows.Forms.Button();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labelError3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDisk1Total = new System.Windows.Forms.Label();
            this.labelDisk1Remain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupPC1 = new System.Windows.Forms.GroupBox();
            this.BarCPU1 = new System.Windows.Forms.ProgressBar();
            this.BarRAM1 = new System.Windows.Forms.ProgressBar();
            this.labelCpu1Used = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelRam1Used = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRam1Size = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDisk1Used = new System.Windows.Forms.Label();
            this.BarDD1 = new System.Windows.Forms.ProgressBar();
            this.groupPC2 = new System.Windows.Forms.GroupBox();
            this.BarCPU2 = new System.Windows.Forms.ProgressBar();
            this.BarRAM2 = new System.Windows.Forms.ProgressBar();
            this.labelCpu2Used = new System.Windows.Forms.Label();
            this.labelRam2Used = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelRam2Size = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDisk2Used = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BarDD2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDisk2Remain = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDisk2Total = new System.Windows.Forms.Label();
            this.groupPC3 = new System.Windows.Forms.GroupBox();
            this.BarCPU3 = new System.Windows.Forms.ProgressBar();
            this.BarRAM3 = new System.Windows.Forms.ProgressBar();
            this.labelCpu3Used = new System.Windows.Forms.Label();
            this.labelRam3Used = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelRam3Size = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelDisk3Used = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BarDD3 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDisk3Remain = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDisk3Total = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonEquipement = new System.Windows.Forms.ToolStripButton();
            this.ButtonTickets = new System.Windows.Forms.ToolStripButton();
            this.ButtonProfils = new System.Windows.Forms.ToolStripButton();
            this.groupTicketSoumis = new System.Windows.Forms.GroupBox();
            this.groupTicketEnCours = new System.Windows.Forms.GroupBox();
            this.groupTicketsResolues = new System.Windows.Forms.GroupBox();
            this.groupProfils = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonTicket1 = new System.Windows.Forms.Button();
            this.buttonTicket2 = new System.Windows.Forms.Button();
            this.buttonTicket3 = new System.Windows.Forms.Button();
            this.groupPC1.SuspendLayout();
            this.groupPC2.SuspendLayout();
            this.groupPC3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLog1
            // 
            this.buttonLog1.Location = new System.Drawing.Point(219, 317);
            this.buttonLog1.Name = "buttonLog1";
            this.buttonLog1.Size = new System.Drawing.Size(75, 23);
            this.buttonLog1.TabIndex = 0;
            this.buttonLog1.Text = "Logs PC1";
            this.buttonLog1.UseVisualStyleBackColor = true;
            this.buttonLog1.Click += new System.EventHandler(this.buttonLog1_Click);
            // 
            // buttonLog3
            // 
            this.buttonLog3.Location = new System.Drawing.Point(216, 317);
            this.buttonLog3.Name = "buttonLog3";
            this.buttonLog3.Size = new System.Drawing.Size(75, 23);
            this.buttonLog3.TabIndex = 2;
            this.buttonLog3.Text = "Logs PC3";
            this.buttonLog3.UseVisualStyleBackColor = true;
            this.buttonLog3.Click += new System.EventHandler(this.buttonLog3_Click);
            // 
            // buttonLog2
            // 
            this.buttonLog2.Location = new System.Drawing.Point(219, 317);
            this.buttonLog2.Name = "buttonLog2";
            this.buttonLog2.Size = new System.Drawing.Size(75, 23);
            this.buttonLog2.TabIndex = 3;
            this.buttonLog2.Text = "Logs PC2";
            this.buttonLog2.UseVisualStyleBackColor = true;
            this.buttonLog2.Click += new System.EventHandler(this.buttonLog2_Click);
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(240, 343);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(29, 13);
            this.labelError1.TabIndex = 4;
            this.labelError1.Text = "Error";
            this.labelError1.Visible = false;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(243, 343);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(29, 13);
            this.labelError2.TabIndex = 5;
            this.labelError2.Text = "Error";
            this.labelError2.Visible = false;
            // 
            // labelError3
            // 
            this.labelError3.AutoSize = true;
            this.labelError3.ForeColor = System.Drawing.Color.Red;
            this.labelError3.Location = new System.Drawing.Point(240, 343);
            this.labelError3.Name = "labelError3";
            this.labelError3.Size = new System.Drawing.Size(29, 13);
            this.labelError3.TabIndex = 6;
            this.labelError3.Text = "Error";
            this.labelError3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Espace total :";
            // 
            // labelDisk1Total
            // 
            this.labelDisk1Total.AutoSize = true;
            this.labelDisk1Total.Location = new System.Drawing.Point(88, 36);
            this.labelDisk1Total.Name = "labelDisk1Total";
            this.labelDisk1Total.Size = new System.Drawing.Size(10, 13);
            this.labelDisk1Total.TabIndex = 8;
            this.labelDisk1Total.Text = "-";
            // 
            // labelDisk1Remain
            // 
            this.labelDisk1Remain.AutoSize = true;
            this.labelDisk1Remain.Location = new System.Drawing.Point(88, 60);
            this.labelDisk1Remain.Name = "labelDisk1Remain";
            this.labelDisk1Remain.Size = new System.Drawing.Size(10, 13);
            this.labelDisk1Remain.TabIndex = 10;
            this.labelDisk1Remain.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Espace libre :";
            // 
            // groupPC1
            // 
            this.groupPC1.Controls.Add(this.buttonTicket1);
            this.groupPC1.Controls.Add(this.BarCPU1);
            this.groupPC1.Controls.Add(this.BarRAM1);
            this.groupPC1.Controls.Add(this.labelCpu1Used);
            this.groupPC1.Controls.Add(this.label13);
            this.groupPC1.Controls.Add(this.labelRam1Used);
            this.groupPC1.Controls.Add(this.label8);
            this.groupPC1.Controls.Add(this.labelRam1Size);
            this.groupPC1.Controls.Add(this.label2);
            this.groupPC1.Controls.Add(this.labelDisk1Used);
            this.groupPC1.Controls.Add(this.BarDD1);
            this.groupPC1.Controls.Add(this.label1);
            this.groupPC1.Controls.Add(this.buttonLog1);
            this.groupPC1.Controls.Add(this.labelError1);
            this.groupPC1.Controls.Add(this.labelDisk1Remain);
            this.groupPC1.Controls.Add(this.labelDisk1Total);
            this.groupPC1.Controls.Add(this.label4);
            this.groupPC1.Location = new System.Drawing.Point(12, 37);
            this.groupPC1.Name = "groupPC1";
            this.groupPC1.Size = new System.Drawing.Size(300, 363);
            this.groupPC1.TabIndex = 11;
            this.groupPC1.TabStop = false;
            this.groupPC1.Text = "PC1";
            // 
            // BarCPU1
            // 
            this.BarCPU1.Location = new System.Drawing.Point(129, 174);
            this.BarCPU1.Name = "BarCPU1";
            this.BarCPU1.Size = new System.Drawing.Size(165, 20);
            this.BarCPU1.TabIndex = 20;
            // 
            // BarRAM1
            // 
            this.BarRAM1.Location = new System.Drawing.Point(129, 132);
            this.BarRAM1.Name = "BarRAM1";
            this.BarRAM1.Size = new System.Drawing.Size(165, 20);
            this.BarRAM1.TabIndex = 19;
            // 
            // labelCpu1Used
            // 
            this.labelCpu1Used.AutoSize = true;
            this.labelCpu1Used.Location = new System.Drawing.Point(88, 181);
            this.labelCpu1Used.Name = "labelCpu1Used";
            this.labelCpu1Used.Size = new System.Drawing.Size(10, 13);
            this.labelCpu1Used.TabIndex = 18;
            this.labelCpu1Used.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "CPU utilisée :";
            // 
            // labelRam1Used
            // 
            this.labelRam1Used.AutoSize = true;
            this.labelRam1Used.Location = new System.Drawing.Point(88, 139);
            this.labelRam1Used.Name = "labelRam1Used";
            this.labelRam1Used.Size = new System.Drawing.Size(10, 13);
            this.labelRam1Used.TabIndex = 16;
            this.labelRam1Used.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "RAM utilisée :";
            // 
            // labelRam1Size
            // 
            this.labelRam1Size.AutoSize = true;
            this.labelRam1Size.Location = new System.Drawing.Point(88, 116);
            this.labelRam1Size.Name = "labelRam1Size";
            this.labelRam1Size.Size = new System.Drawing.Size(10, 13);
            this.labelRam1Size.TabIndex = 14;
            this.labelRam1Size.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "RAM installée :";
            // 
            // labelDisk1Used
            // 
            this.labelDisk1Used.AutoSize = true;
            this.labelDisk1Used.Location = new System.Drawing.Point(6, 82);
            this.labelDisk1Used.Name = "labelDisk1Used";
            this.labelDisk1Used.Size = new System.Drawing.Size(108, 13);
            this.labelDisk1Used.TabIndex = 12;
            this.labelDisk1Used.Text = "Espace occupé (-%) :";
            // 
            // BarDD1
            // 
            this.BarDD1.Location = new System.Drawing.Point(129, 82);
            this.BarDD1.Name = "BarDD1";
            this.BarDD1.Size = new System.Drawing.Size(165, 20);
            this.BarDD1.TabIndex = 11;
            // 
            // groupPC2
            // 
            this.groupPC2.Controls.Add(this.buttonTicket2);
            this.groupPC2.Controls.Add(this.BarCPU2);
            this.groupPC2.Controls.Add(this.BarRAM2);
            this.groupPC2.Controls.Add(this.labelCpu2Used);
            this.groupPC2.Controls.Add(this.labelRam2Used);
            this.groupPC2.Controls.Add(this.label15);
            this.groupPC2.Controls.Add(this.labelRam2Size);
            this.groupPC2.Controls.Add(this.label11);
            this.groupPC2.Controls.Add(this.labelDisk2Used);
            this.groupPC2.Controls.Add(this.label6);
            this.groupPC2.Controls.Add(this.buttonLog2);
            this.groupPC2.Controls.Add(this.BarDD2);
            this.groupPC2.Controls.Add(this.labelError2);
            this.groupPC2.Controls.Add(this.label3);
            this.groupPC2.Controls.Add(this.labelDisk2Remain);
            this.groupPC2.Controls.Add(this.label7);
            this.groupPC2.Controls.Add(this.labelDisk2Total);
            this.groupPC2.Location = new System.Drawing.Point(318, 37);
            this.groupPC2.Name = "groupPC2";
            this.groupPC2.Size = new System.Drawing.Size(300, 363);
            this.groupPC2.TabIndex = 12;
            this.groupPC2.TabStop = false;
            this.groupPC2.Text = "PC2";
            // 
            // BarCPU2
            // 
            this.BarCPU2.Location = new System.Drawing.Point(129, 174);
            this.BarCPU2.Name = "BarCPU2";
            this.BarCPU2.Size = new System.Drawing.Size(165, 20);
            this.BarCPU2.TabIndex = 22;
            // 
            // BarRAM2
            // 
            this.BarRAM2.Location = new System.Drawing.Point(129, 132);
            this.BarRAM2.Name = "BarRAM2";
            this.BarRAM2.Size = new System.Drawing.Size(165, 20);
            this.BarRAM2.TabIndex = 21;
            // 
            // labelCpu2Used
            // 
            this.labelCpu2Used.AutoSize = true;
            this.labelCpu2Used.Location = new System.Drawing.Point(88, 181);
            this.labelCpu2Used.Name = "labelCpu2Used";
            this.labelCpu2Used.Size = new System.Drawing.Size(10, 13);
            this.labelCpu2Used.TabIndex = 20;
            this.labelCpu2Used.Text = "-";
            // 
            // labelRam2Used
            // 
            this.labelRam2Used.AutoSize = true;
            this.labelRam2Used.Location = new System.Drawing.Point(88, 139);
            this.labelRam2Used.Name = "labelRam2Used";
            this.labelRam2Used.Size = new System.Drawing.Size(10, 13);
            this.labelRam2Used.TabIndex = 18;
            this.labelRam2Used.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "CPU utilisée :";
            // 
            // labelRam2Size
            // 
            this.labelRam2Size.AutoSize = true;
            this.labelRam2Size.Location = new System.Drawing.Point(88, 116);
            this.labelRam2Size.Name = "labelRam2Size";
            this.labelRam2Size.Size = new System.Drawing.Size(10, 13);
            this.labelRam2Size.TabIndex = 16;
            this.labelRam2Size.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "RAM utilisée :";
            // 
            // labelDisk2Used
            // 
            this.labelDisk2Used.AutoSize = true;
            this.labelDisk2Used.Location = new System.Drawing.Point(6, 82);
            this.labelDisk2Used.Name = "labelDisk2Used";
            this.labelDisk2Used.Size = new System.Drawing.Size(108, 13);
            this.labelDisk2Used.TabIndex = 18;
            this.labelDisk2Used.Text = "Espace occupé (-%) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "RAM installée :";
            // 
            // BarDD2
            // 
            this.BarDD2.Location = new System.Drawing.Point(129, 82);
            this.BarDD2.Name = "BarDD2";
            this.BarDD2.Size = new System.Drawing.Size(165, 20);
            this.BarDD2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Espace total :";
            // 
            // labelDisk2Remain
            // 
            this.labelDisk2Remain.AutoSize = true;
            this.labelDisk2Remain.Location = new System.Drawing.Point(88, 60);
            this.labelDisk2Remain.Name = "labelDisk2Remain";
            this.labelDisk2Remain.Size = new System.Drawing.Size(10, 13);
            this.labelDisk2Remain.TabIndex = 16;
            this.labelDisk2Remain.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Espace libre :";
            // 
            // labelDisk2Total
            // 
            this.labelDisk2Total.AutoSize = true;
            this.labelDisk2Total.Location = new System.Drawing.Point(88, 36);
            this.labelDisk2Total.Name = "labelDisk2Total";
            this.labelDisk2Total.Size = new System.Drawing.Size(10, 13);
            this.labelDisk2Total.TabIndex = 14;
            this.labelDisk2Total.Text = "-";
            // 
            // groupPC3
            // 
            this.groupPC3.Controls.Add(this.buttonTicket3);
            this.groupPC3.Controls.Add(this.BarCPU3);
            this.groupPC3.Controls.Add(this.BarRAM3);
            this.groupPC3.Controls.Add(this.labelCpu3Used);
            this.groupPC3.Controls.Add(this.labelRam3Used);
            this.groupPC3.Controls.Add(this.label17);
            this.groupPC3.Controls.Add(this.labelRam3Size);
            this.groupPC3.Controls.Add(this.label14);
            this.groupPC3.Controls.Add(this.labelDisk3Used);
            this.groupPC3.Controls.Add(this.label10);
            this.groupPC3.Controls.Add(this.buttonLog3);
            this.groupPC3.Controls.Add(this.BarDD3);
            this.groupPC3.Controls.Add(this.labelError3);
            this.groupPC3.Controls.Add(this.label9);
            this.groupPC3.Controls.Add(this.labelDisk3Remain);
            this.groupPC3.Controls.Add(this.label12);
            this.groupPC3.Controls.Add(this.labelDisk3Total);
            this.groupPC3.Location = new System.Drawing.Point(624, 37);
            this.groupPC3.Name = "groupPC3";
            this.groupPC3.Size = new System.Drawing.Size(300, 363);
            this.groupPC3.TabIndex = 12;
            this.groupPC3.TabStop = false;
            this.groupPC3.Text = "PC3";
            // 
            // BarCPU3
            // 
            this.BarCPU3.Location = new System.Drawing.Point(129, 174);
            this.BarCPU3.Name = "BarCPU3";
            this.BarCPU3.Size = new System.Drawing.Size(165, 20);
            this.BarCPU3.TabIndex = 25;
            // 
            // BarRAM3
            // 
            this.BarRAM3.Location = new System.Drawing.Point(129, 132);
            this.BarRAM3.Name = "BarRAM3";
            this.BarRAM3.Size = new System.Drawing.Size(165, 20);
            this.BarRAM3.TabIndex = 23;
            // 
            // labelCpu3Used
            // 
            this.labelCpu3Used.AutoSize = true;
            this.labelCpu3Used.Location = new System.Drawing.Point(88, 181);
            this.labelCpu3Used.Name = "labelCpu3Used";
            this.labelCpu3Used.Size = new System.Drawing.Size(10, 13);
            this.labelCpu3Used.TabIndex = 22;
            this.labelCpu3Used.Text = "-";
            // 
            // labelRam3Used
            // 
            this.labelRam3Used.AutoSize = true;
            this.labelRam3Used.Location = new System.Drawing.Point(88, 139);
            this.labelRam3Used.Name = "labelRam3Used";
            this.labelRam3Used.Size = new System.Drawing.Size(10, 13);
            this.labelRam3Used.TabIndex = 20;
            this.labelRam3Used.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "CPU utilisée :";
            // 
            // labelRam3Size
            // 
            this.labelRam3Size.AutoSize = true;
            this.labelRam3Size.Location = new System.Drawing.Point(88, 116);
            this.labelRam3Size.Name = "labelRam3Size";
            this.labelRam3Size.Size = new System.Drawing.Size(10, 13);
            this.labelRam3Size.TabIndex = 20;
            this.labelRam3Size.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "RAM utilisée :";
            // 
            // labelDisk3Used
            // 
            this.labelDisk3Used.AutoSize = true;
            this.labelDisk3Used.Location = new System.Drawing.Point(6, 82);
            this.labelDisk3Used.Name = "labelDisk3Used";
            this.labelDisk3Used.Size = new System.Drawing.Size(108, 13);
            this.labelDisk3Used.TabIndex = 24;
            this.labelDisk3Used.Text = "Espace occupé (-%) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "RAM installée :";
            // 
            // BarDD3
            // 
            this.BarDD3.Location = new System.Drawing.Point(129, 82);
            this.BarDD3.Name = "BarDD3";
            this.BarDD3.Size = new System.Drawing.Size(165, 20);
            this.BarDD3.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Espace total :";
            // 
            // labelDisk3Remain
            // 
            this.labelDisk3Remain.AutoSize = true;
            this.labelDisk3Remain.Location = new System.Drawing.Point(88, 60);
            this.labelDisk3Remain.Name = "labelDisk3Remain";
            this.labelDisk3Remain.Size = new System.Drawing.Size(10, 13);
            this.labelDisk3Remain.TabIndex = 22;
            this.labelDisk3Remain.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Espace libre :";
            // 
            // labelDisk3Total
            // 
            this.labelDisk3Total.AutoSize = true;
            this.labelDisk3Total.Location = new System.Drawing.Point(88, 36);
            this.labelDisk3Total.Name = "labelDisk3Total";
            this.labelDisk3Total.Size = new System.Drawing.Size(10, 13);
            this.labelDisk3Total.TabIndex = 20;
            this.labelDisk3Total.Text = "-";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonEquipement,
            this.ButtonTickets,
            this.ButtonProfils});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonEquipement
            // 
            this.ButtonEquipement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonEquipement.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEquipement.Image")));
            this.ButtonEquipement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonEquipement.Name = "ButtonEquipement";
            this.ButtonEquipement.Size = new System.Drawing.Size(75, 22);
            this.ButtonEquipement.Text = "Equipement";
            this.ButtonEquipement.Click += new System.EventHandler(this.ButtonEquipement_Click);
            // 
            // ButtonTickets
            // 
            this.ButtonTickets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonTickets.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTickets.Image")));
            this.ButtonTickets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonTickets.Name = "ButtonTickets";
            this.ButtonTickets.Size = new System.Drawing.Size(48, 22);
            this.ButtonTickets.Text = "Tickets";
            this.ButtonTickets.Click += new System.EventHandler(this.ButtonTickets_Click);
            // 
            // ButtonProfils
            // 
            this.ButtonProfils.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonProfils.Image = ((System.Drawing.Image)(resources.GetObject("ButtonProfils.Image")));
            this.ButtonProfils.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonProfils.Name = "ButtonProfils";
            this.ButtonProfils.Size = new System.Drawing.Size(44, 22);
            this.ButtonProfils.Text = "Profils";
            this.ButtonProfils.ToolTipText = "Profils";
            this.ButtonProfils.Click += new System.EventHandler(this.ButtonProfils_Click);
            // 
            // groupTicketSoumis
            // 
            this.groupTicketSoumis.Location = new System.Drawing.Point(12, 37);
            this.groupTicketSoumis.Name = "groupTicketSoumis";
            this.groupTicketSoumis.Size = new System.Drawing.Size(300, 363);
            this.groupTicketSoumis.TabIndex = 14;
            this.groupTicketSoumis.TabStop = false;
            this.groupTicketSoumis.Text = "Tickets Soumis";
            // 
            // groupTicketEnCours
            // 
            this.groupTicketEnCours.Location = new System.Drawing.Point(318, 37);
            this.groupTicketEnCours.Name = "groupTicketEnCours";
            this.groupTicketEnCours.Size = new System.Drawing.Size(300, 363);
            this.groupTicketEnCours.TabIndex = 15;
            this.groupTicketEnCours.TabStop = false;
            this.groupTicketEnCours.Text = "Tickets en cours";
            // 
            // groupTicketsResolues
            // 
            this.groupTicketsResolues.Location = new System.Drawing.Point(624, 37);
            this.groupTicketsResolues.Name = "groupTicketsResolues";
            this.groupTicketsResolues.Size = new System.Drawing.Size(300, 363);
            this.groupTicketsResolues.TabIndex = 16;
            this.groupTicketsResolues.TabStop = false;
            this.groupTicketsResolues.Text = "Tickets résolues";
            // 
            // groupProfils
            // 
            this.groupProfils.Location = new System.Drawing.Point(9, 37);
            this.groupProfils.Name = "groupProfils";
            this.groupProfils.Size = new System.Drawing.Size(912, 363);
            this.groupProfils.TabIndex = 17;
            this.groupProfils.TabStop = false;
            this.groupProfils.Text = "Profils";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonTicket1
            // 
            this.buttonTicket1.Location = new System.Drawing.Point(4, 317);
            this.buttonTicket1.Name = "buttonTicket1";
            this.buttonTicket1.Size = new System.Drawing.Size(110, 23);
            this.buttonTicket1.TabIndex = 21;
            this.buttonTicket1.Text = "Envoyer un ticket";
            this.buttonTicket1.UseVisualStyleBackColor = true;
            this.buttonTicket1.Click += new System.EventHandler(this.buttonTicket1_Click);
            // 
            // buttonTicket2
            // 
            this.buttonTicket2.Location = new System.Drawing.Point(6, 317);
            this.buttonTicket2.Name = "buttonTicket2";
            this.buttonTicket2.Size = new System.Drawing.Size(110, 23);
            this.buttonTicket2.TabIndex = 22;
            this.buttonTicket2.Text = "Envoyer un ticket";
            this.buttonTicket2.UseVisualStyleBackColor = true;
            this.buttonTicket2.Click += new System.EventHandler(this.buttonTicket2_Click);
            // 
            // buttonTicket3
            // 
            this.buttonTicket3.Location = new System.Drawing.Point(6, 317);
            this.buttonTicket3.Name = "buttonTicket3";
            this.buttonTicket3.Size = new System.Drawing.Size(110, 23);
            this.buttonTicket3.TabIndex = 23;
            this.buttonTicket3.Text = "Envoyer un ticket";
            this.buttonTicket3.UseVisualStyleBackColor = true;
            this.buttonTicket3.Click += new System.EventHandler(this.buttonTicket3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 408);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupPC2);
            this.Controls.Add(this.groupPC1);
            this.Controls.Add(this.groupPC3);
            this.Controls.Add(this.groupProfils);
            this.Controls.Add(this.groupTicketEnCours);
            this.Controls.Add(this.groupTicketSoumis);
            this.Controls.Add(this.groupTicketsResolues);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisator 2001";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupPC1.ResumeLayout(false);
            this.groupPC1.PerformLayout();
            this.groupPC2.ResumeLayout(false);
            this.groupPC2.PerformLayout();
            this.groupPC3.ResumeLayout(false);
            this.groupPC3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLog1;
        private System.Windows.Forms.Button buttonLog3;
        private System.Windows.Forms.Button buttonLog2;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Label labelError3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDisk1Total;
        private System.Windows.Forms.Label labelDisk1Remain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupPC1;
        private System.Windows.Forms.GroupBox groupPC2;
        private System.Windows.Forms.GroupBox groupPC3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonEquipement;
        private System.Windows.Forms.ToolStripButton ButtonTickets;
        private System.Windows.Forms.ToolStripButton ButtonProfils;
        private System.Windows.Forms.GroupBox groupTicketEnCours;
        private System.Windows.Forms.GroupBox groupTicketSoumis;
        private System.Windows.Forms.GroupBox groupTicketsResolues;
        private System.Windows.Forms.GroupBox groupProfils;
        private System.Windows.Forms.ProgressBar BarDD1;
        private System.Windows.Forms.Label labelDisk1Used;
        private System.Windows.Forms.Label labelDisk2Used;
        private System.Windows.Forms.ProgressBar BarDD2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDisk2Remain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDisk2Total;
        private System.Windows.Forms.Label labelDisk3Used;
        private System.Windows.Forms.ProgressBar BarDD3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDisk3Remain;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelDisk3Total;
        private System.Windows.Forms.Label labelRam1Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRam2Size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRam3Size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelRam1Used;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRam2Used;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelRam3Used;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCpu1Used;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelCpu2Used;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelCpu3Used;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar BarCPU1;
        private System.Windows.Forms.ProgressBar BarRAM1;
        private System.Windows.Forms.ProgressBar BarCPU2;
        private System.Windows.Forms.ProgressBar BarRAM2;
        private System.Windows.Forms.ProgressBar BarCPU3;
        private System.Windows.Forms.ProgressBar BarRAM3;
        private System.Windows.Forms.Button buttonTicket1;
        private System.Windows.Forms.Button buttonTicket2;
        private System.Windows.Forms.Button buttonTicket3;
    }
}