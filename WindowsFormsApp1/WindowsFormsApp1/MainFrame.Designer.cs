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
            this.labelDisk1Used = new System.Windows.Forms.Label();
            this.BarDD1 = new System.Windows.Forms.ProgressBar();
            this.groupPC2 = new System.Windows.Forms.GroupBox();
            this.groupPC3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonEquipement = new System.Windows.Forms.ToolStripButton();
            this.ButtonTickets = new System.Windows.Forms.ToolStripButton();
            this.ButtonProfils = new System.Windows.Forms.ToolStripButton();
            this.groupTicketSoumis = new System.Windows.Forms.GroupBox();
            this.groupTicketEnCours = new System.Windows.Forms.GroupBox();
            this.groupTicketsResolues = new System.Windows.Forms.GroupBox();
            this.groupProfils = new System.Windows.Forms.GroupBox();
            this.labelDisk2Used = new System.Windows.Forms.Label();
            this.BarDD2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDisk2Remain = new System.Windows.Forms.Label();
            this.labelDisk2Total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDisk3Used = new System.Windows.Forms.Label();
            this.BarDD3 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDisk3Remain = new System.Windows.Forms.Label();
            this.labelDisk3Total = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupPC1.SuspendLayout();
            this.groupPC2.SuspendLayout();
            this.groupPC3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLog1
            // 
            this.buttonLog1.Location = new System.Drawing.Point(93, 310);
            this.buttonLog1.Name = "buttonLog1";
            this.buttonLog1.Size = new System.Drawing.Size(75, 23);
            this.buttonLog1.TabIndex = 0;
            this.buttonLog1.Text = "Logs PC1";
            this.buttonLog1.UseVisualStyleBackColor = true;
            this.buttonLog1.Click += new System.EventHandler(this.buttonLog1_Click);
            // 
            // buttonLog3
            // 
            this.buttonLog3.Location = new System.Drawing.Point(114, 310);
            this.buttonLog3.Name = "buttonLog3";
            this.buttonLog3.Size = new System.Drawing.Size(75, 23);
            this.buttonLog3.TabIndex = 2;
            this.buttonLog3.Text = "Logs PC3";
            this.buttonLog3.UseVisualStyleBackColor = true;
            this.buttonLog3.Click += new System.EventHandler(this.buttonLog3_Click);
            // 
            // buttonLog2
            // 
            this.buttonLog2.Location = new System.Drawing.Point(110, 310);
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
            this.labelError1.Location = new System.Drawing.Point(114, 336);
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
            this.labelError2.Location = new System.Drawing.Point(134, 336);
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
            this.labelError3.Location = new System.Drawing.Point(135, 336);
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
            this.groupPC2.Controls.Add(this.labelDisk2Used);
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
            // groupPC3
            // 
            this.groupPC3.Controls.Add(this.labelDisk3Used);
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
            // labelDisk2Used
            // 
            this.labelDisk2Used.AutoSize = true;
            this.labelDisk2Used.Location = new System.Drawing.Point(6, 82);
            this.labelDisk2Used.Name = "labelDisk2Used";
            this.labelDisk2Used.Size = new System.Drawing.Size(108, 13);
            this.labelDisk2Used.TabIndex = 18;
            this.labelDisk2Used.Text = "Espace occupé (-%) :";
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
            // labelDisk2Total
            // 
            this.labelDisk2Total.AutoSize = true;
            this.labelDisk2Total.Location = new System.Drawing.Point(88, 36);
            this.labelDisk2Total.Name = "labelDisk2Total";
            this.labelDisk2Total.Size = new System.Drawing.Size(10, 13);
            this.labelDisk2Total.TabIndex = 14;
            this.labelDisk2Total.Text = "-";
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
            // labelDisk3Used
            // 
            this.labelDisk3Used.AutoSize = true;
            this.labelDisk3Used.Location = new System.Drawing.Point(6, 82);
            this.labelDisk3Used.Name = "labelDisk3Used";
            this.labelDisk3Used.Size = new System.Drawing.Size(108, 13);
            this.labelDisk3Used.TabIndex = 24;
            this.labelDisk3Used.Text = "Espace occupé (-%) :";
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
            // labelDisk3Total
            // 
            this.labelDisk3Total.AutoSize = true;
            this.labelDisk3Total.Location = new System.Drawing.Point(88, 36);
            this.labelDisk3Total.Name = "labelDisk3Total";
            this.labelDisk3Total.Size = new System.Drawing.Size(10, 13);
            this.labelDisk3Total.TabIndex = 20;
            this.labelDisk3Total.Text = "-";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 400);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupPC2);
            this.Controls.Add(this.groupPC1);
            this.Controls.Add(this.groupPC3);
            this.Controls.Add(this.groupProfils);
            this.Controls.Add(this.groupTicketEnCours);
            this.Controls.Add(this.groupTicketSoumis);
            this.Controls.Add(this.groupTicketsResolues);
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
    }
}