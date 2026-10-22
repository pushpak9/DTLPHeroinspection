using System.Windows.Forms;

namespace HeroInspection.Forms.Transaction
{
    partial class ProductScanning
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

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox grpScanner;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.Label lblScannerIP;
        private System.Windows.Forms.Label lblScannerPort;
        private System.Windows.Forms.Label lblInspection;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Label lblNG;

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpScanner = new System.Windows.Forms.GroupBox();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.lblPart = new System.Windows.Forms.Label();
            this.cmbPartCode = new System.Windows.Forms.ComboBox();
            this.lblSlot = new System.Windows.Forms.Label();
            this.txtSlotNo = new System.Windows.Forms.TextBox();
            this.lblScannerIP = new System.Windows.Forms.Label();
            this.txtScannerIP = new System.Windows.Forms.TextBox();
            this.lblScannerPort = new System.Windows.Forms.Label();
            this.txtScannerPort = new System.Windows.Forms.TextBox();
            this.PanelStart = new System.Windows.Forms.GroupBox();
            this.PanelStop = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxttPassword = new System.Windows.Forms.TextBox();
            this.TxttUserId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.TxUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.TxttDuplicate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReadFailed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInspection = new System.Windows.Forms.Label();
            this.TxtInspection = new System.Windows.Forms.TextBox();
            this.lblOK = new System.Windows.Forms.Label();
            this.TotalOK = new System.Windows.Forms.TextBox();
            this.lblNG = new System.Windows.Forms.Label();
            this.TxtNg = new System.Windows.Forms.TextBox();
            this.lblHardwareFailMessage = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InspectionDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvdata = new System.Windows.Forms.ListView();
            this.btnstatus = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpScanner.SuspendLayout();
            this.PanelStart.SuspendLayout();
            this.PanelStop.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1773, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1773, 85);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PART VERIFICATION";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpScanner
            // 
            this.grpScanner.BackColor = System.Drawing.Color.White;
            this.grpScanner.Controls.Add(this.cmbShift);
            this.grpScanner.Controls.Add(this.label16);
            this.grpScanner.Controls.Add(this.cmbCountry);
            this.grpScanner.Controls.Add(this.label15);
            this.grpScanner.Controls.Add(this.TxtStatus);
            this.grpScanner.Controls.Add(this.lblPart);
            this.grpScanner.Controls.Add(this.cmbPartCode);
            this.grpScanner.Controls.Add(this.lblSlot);
            this.grpScanner.Controls.Add(this.txtSlotNo);
            this.grpScanner.Controls.Add(this.lblScannerIP);
            this.grpScanner.Controls.Add(this.txtScannerIP);
            this.grpScanner.Controls.Add(this.lblScannerPort);
            this.grpScanner.Controls.Add(this.txtScannerPort);
            this.grpScanner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpScanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.grpScanner.Location = new System.Drawing.Point(25, 110);
            this.grpScanner.Name = "grpScanner";
            this.grpScanner.Size = new System.Drawing.Size(670, 354);
            this.grpScanner.TabIndex = 1;
            this.grpScanner.TabStop = false;
            this.grpScanner.Text = "Scanner Configuration";
            this.grpScanner.Enter += new System.EventHandler(this.grpScanner_Enter);
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbShift.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbShift.Location = new System.Drawing.Point(202, 203);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(317, 33);
            this.cmbShift.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(21, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "Shift";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCountry.Location = new System.Drawing.Point(202, 31);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(317, 33);
            this.cmbCountry.TabIndex = 10;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(21, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Country";
            // 
            // TxtStatus
            // 
            this.TxtStatus.BackColor = System.Drawing.Color.White;
            this.TxtStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TxtStatus.Location = new System.Drawing.Point(569, 40);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.ReadOnly = true;
            this.TxtStatus.Size = new System.Drawing.Size(78, 47);
            this.TxtStatus.TabIndex = 8;
            this.TxtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPart.Location = new System.Drawing.Point(21, 101);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(107, 25);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "Select Part";
            // 
            // cmbPartCode
            // 
            this.cmbPartCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPartCode.Location = new System.Drawing.Point(202, 93);
            this.cmbPartCode.Name = "cmbPartCode";
            this.cmbPartCode.Size = new System.Drawing.Size(317, 33);
            this.cmbPartCode.TabIndex = 1;
            this.cmbPartCode.SelectedIndexChanged += new System.EventHandler(this.cmbPartCode_SelectedIndexChanged);
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSlot.Location = new System.Drawing.Point(21, 160);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(79, 25);
            this.lblSlot.TabIndex = 2;
            this.lblSlot.Text = "Slot No";
            // 
            // txtSlotNo
            // 
            this.txtSlotNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSlotNo.Location = new System.Drawing.Point(202, 153);
            this.txtSlotNo.Name = "txtSlotNo";
            this.txtSlotNo.ReadOnly = true;
            this.txtSlotNo.Size = new System.Drawing.Size(317, 32);
            this.txtSlotNo.TabIndex = 3;
            // 
            // lblScannerIP
            // 
            this.lblScannerIP.AutoSize = true;
            this.lblScannerIP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScannerIP.Location = new System.Drawing.Point(21, 263);
            this.lblScannerIP.Name = "lblScannerIP";
            this.lblScannerIP.Size = new System.Drawing.Size(107, 25);
            this.lblScannerIP.TabIndex = 4;
            this.lblScannerIP.Text = "Scanner IP";
            // 
            // txtScannerIP
            // 
            this.txtScannerIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtScannerIP.Location = new System.Drawing.Point(202, 256);
            this.txtScannerIP.Name = "txtScannerIP";
            this.txtScannerIP.ReadOnly = true;
            this.txtScannerIP.Size = new System.Drawing.Size(317, 32);
            this.txtScannerIP.TabIndex = 5;
            // 
            // lblScannerPort
            // 
            this.lblScannerPort.AutoSize = true;
            this.lblScannerPort.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScannerPort.Location = new System.Drawing.Point(21, 312);
            this.lblScannerPort.Name = "lblScannerPort";
            this.lblScannerPort.Size = new System.Drawing.Size(128, 25);
            this.lblScannerPort.TabIndex = 6;
            this.lblScannerPort.Text = "Scanner Port";
            // 
            // txtScannerPort
            // 
            this.txtScannerPort.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtScannerPort.Location = new System.Drawing.Point(202, 309);
            this.txtScannerPort.Name = "txtScannerPort";
            this.txtScannerPort.ReadOnly = true;
            this.txtScannerPort.Size = new System.Drawing.Size(323, 32);
            this.txtScannerPort.TabIndex = 7;
            // 
            // PanelStart
            // 
            this.PanelStart.BackColor = System.Drawing.Color.White;
            this.PanelStart.Controls.Add(this.PanelStop);
            this.PanelStart.Controls.Add(this.label14);
            this.PanelStart.Controls.Add(this.button2);
            this.PanelStart.Controls.Add(this.button1);
            this.PanelStart.Controls.Add(this.TxPassword);
            this.PanelStart.Controls.Add(this.TxUserID);
            this.PanelStart.Controls.Add(this.label7);
            this.PanelStart.Controls.Add(this.label12);
            this.PanelStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.PanelStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.PanelStart.Location = new System.Drawing.Point(761, 110);
            this.PanelStart.Name = "PanelStart";
            this.PanelStart.Size = new System.Drawing.Size(515, 309);
            this.PanelStart.TabIndex = 10;
            this.PanelStart.TabStop = false;
            // 
            // PanelStop
            // 
            this.PanelStop.BackColor = System.Drawing.Color.White;
            this.PanelStop.Controls.Add(this.button9);
            this.PanelStop.Controls.Add(this.button10);
            this.PanelStop.Controls.Add(this.label13);
            this.PanelStop.Controls.Add(this.TxttPassword);
            this.PanelStop.Controls.Add(this.TxttUserId);
            this.PanelStop.Controls.Add(this.label8);
            this.PanelStop.Controls.Add(this.label11);
            this.PanelStop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.PanelStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.PanelStop.Location = new System.Drawing.Point(26, 26);
            this.PanelStop.Name = "PanelStop";
            this.PanelStop.Size = new System.Drawing.Size(505, 283);
            this.PanelStop.TabIndex = 9;
            this.PanelStop.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(222, 196);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(155, 42);
            this.button9.TabIndex = 8;
            this.button9.Text = "Close";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(46, 200);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 38);
            this.button10.TabIndex = 7;
            this.button10.Text = "Validate";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(146, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 45);
            this.label13.TabIndex = 6;
            this.label13.Text = "Verification";
            // 
            // TxttPassword
            // 
            this.TxttPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxttPassword.Location = new System.Drawing.Point(159, 149);
            this.TxttPassword.Name = "TxttPassword";
            this.TxttPassword.PasswordChar = '*';
            this.TxttPassword.Size = new System.Drawing.Size(276, 32);
            this.TxttPassword.TabIndex = 5;
            // 
            // TxttUserId
            // 
            this.TxttUserId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxttUserId.Location = new System.Drawing.Point(159, 96);
            this.TxttUserId.Name = "TxttUserId";
            this.TxttUserId.Size = new System.Drawing.Size(276, 32);
            this.TxttUserId.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "USER ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(135, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 45);
            this.label14.TabIndex = 10;
            this.label14.Text = "Verification";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(211, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(47, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxPassword
            // 
            this.TxPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxPassword.Location = new System.Drawing.Point(159, 153);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.PasswordChar = '*';
            this.TxPassword.Size = new System.Drawing.Size(276, 32);
            this.TxPassword.TabIndex = 5;
            // 
            // TxUserID
            // 
            this.TxUserID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TxUserID.Location = new System.Drawing.Point(159, 102);
            this.TxUserID.Name = "TxUserID";
            this.TxUserID.Size = new System.Drawing.Size(276, 32);
            this.TxUserID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "USER ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Password";
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.Color.White;
            this.grpSummary.Controls.Add(this.TxttDuplicate);
            this.grpSummary.Controls.Add(this.label17);
            this.grpSummary.Controls.Add(this.txtReadFailed);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.lblInspection);
            this.grpSummary.Controls.Add(this.TxtInspection);
            this.grpSummary.Controls.Add(this.lblOK);
            this.grpSummary.Controls.Add(this.TotalOK);
            this.grpSummary.Controls.Add(this.lblNG);
            this.grpSummary.Controls.Add(this.TxtNg);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.grpSummary.Location = new System.Drawing.Point(838, 101);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(709, 363);
            this.grpSummary.TabIndex = 2;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Inspection Summary";
            // 
            // TxttDuplicate
            // 
            this.TxttDuplicate.BackColor = System.Drawing.Color.LightCoral;
            this.TxttDuplicate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TxttDuplicate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxttDuplicate.Location = new System.Drawing.Point(300, 309);
            this.TxttDuplicate.Name = "TxttDuplicate";
            this.TxttDuplicate.ReadOnly = true;
            this.TxttDuplicate.Size = new System.Drawing.Size(250, 47);
            this.TxttDuplicate.TabIndex = 9;
            this.TxttDuplicate.Text = "0";
            this.TxttDuplicate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 25);
            this.label17.TabIndex = 8;
            this.label17.Text = "Total Duplicate";
            // 
            // txtReadFailed
            // 
            this.txtReadFailed.BackColor = System.Drawing.Color.LightCoral;
            this.txtReadFailed.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtReadFailed.Location = new System.Drawing.Point(300, 249);
            this.txtReadFailed.Name = "txtReadFailed";
            this.txtReadFailed.ReadOnly = true;
            this.txtReadFailed.Size = new System.Drawing.Size(250, 47);
            this.txtReadFailed.TabIndex = 7;
            this.txtReadFailed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Read Failed";
            // 
            // lblInspection
            // 
            this.lblInspection.AutoSize = true;
            this.lblInspection.Location = new System.Drawing.Point(40, 50);
            this.lblInspection.Name = "lblInspection";
            this.lblInspection.Size = new System.Drawing.Size(153, 25);
            this.lblInspection.TabIndex = 0;
            this.lblInspection.Text = "Total Inspection";
            // 
            // TxtInspection
            // 
            this.TxtInspection.BackColor = System.Drawing.Color.LightBlue;
            this.TxtInspection.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TxtInspection.Location = new System.Drawing.Point(300, 34);
            this.TxtInspection.Name = "TxtInspection";
            this.TxtInspection.ReadOnly = true;
            this.TxtInspection.Size = new System.Drawing.Size(250, 47);
            this.TxtInspection.TabIndex = 1;
            this.TxtInspection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Location = new System.Drawing.Point(43, 125);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(86, 25);
            this.lblOK.TabIndex = 2;
            this.lblOK.Text = "Total OK";
            // 
            // TotalOK
            // 
            this.TotalOK.BackColor = System.Drawing.Color.LightGreen;
            this.TotalOK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TotalOK.Location = new System.Drawing.Point(300, 110);
            this.TotalOK.Name = "TotalOK";
            this.TotalOK.ReadOnly = true;
            this.TotalOK.Size = new System.Drawing.Size(250, 47);
            this.TotalOK.TabIndex = 3;
            this.TotalOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNG
            // 
            this.lblNG.AutoSize = true;
            this.lblNG.Location = new System.Drawing.Point(40, 201);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(89, 25);
            this.lblNG.TabIndex = 4;
            this.lblNG.Text = "Total NG";
            // 
            // TxtNg
            // 
            this.TxtNg.BackColor = System.Drawing.Color.LightCoral;
            this.TxtNg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TxtNg.Location = new System.Drawing.Point(300, 185);
            this.TxtNg.Name = "TxtNg";
            this.TxtNg.ReadOnly = true;
            this.TxtNg.Size = new System.Drawing.Size(250, 47);
            this.TxtNg.TabIndex = 5;
            this.TxtNg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHardwareFailMessage
            // 
            this.lblHardwareFailMessage.AutoSize = true;
            this.lblHardwareFailMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHardwareFailMessage.ForeColor = System.Drawing.Color.Red;
            this.lblHardwareFailMessage.Location = new System.Drawing.Point(30, 485);
            this.lblHardwareFailMessage.Name = "lblHardwareFailMessage";
            this.lblHardwareFailMessage.Size = new System.Drawing.Size(0, 23);
            this.lblHardwareFailMessage.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(1320, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(60, 22);
            this.txtResult.TabIndex = 5;
            this.txtResult.Visible = false;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(428, 470);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(200, 55);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(116, 470);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 55);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Barcode";
            this.columnHeader4.Width = 461;
            // 
            // InspectionDateTime
            // 
            this.InspectionDateTime.Text = "Inspection Date Time";
            this.InspectionDateTime.Width = 289;
            // 
            // Result
            // 
            this.Result.Text = "Result";
            this.Result.Width = 817;
            // 
            // lvdata
            // 
            this.lvdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.InspectionDateTime,
            this.Result});
            this.lvdata.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lvdata.ForeColor = System.Drawing.Color.Black;
            this.lvdata.FullRowSelect = true;
            this.lvdata.GridLines = true;
            this.lvdata.HideSelection = false;
            this.lvdata.Location = new System.Drawing.Point(25, 531);
            this.lvdata.MultiSelect = false;
            this.lvdata.Name = "lvdata";
            this.lvdata.ShowGroups = false;
            this.lvdata.ShowItemToolTips = true;
            this.lvdata.Size = new System.Drawing.Size(1748, 499);
            this.lvdata.TabIndex = 9;
            this.lvdata.UseCompatibleStateImageBehavior = false;
            this.lvdata.View = System.Windows.Forms.View.Details;
            // 
            // btnstatus
            // 
            this.btnstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnstatus.FlatAppearance.BorderSize = 0;
            this.btnstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnstatus.ForeColor = System.Drawing.Color.White;
            this.btnstatus.Location = new System.Drawing.Point(719, 470);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(1042, 55);
            this.btnstatus.TabIndex = 10;
            this.btnstatus.Text = "STATUS";
            this.btnstatus.UseVisualStyleBackColor = false;
            // 
            // ProductScanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1773, 1040);
            this.Controls.Add(this.PanelStart);
            this.Controls.Add(this.btnstatus);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.grpScanner);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.lblHardwareFailMessage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lvdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductScanning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part Verification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemValidatation_FormClosing);
            this.Load += new System.EventHandler(this.ItemValidatation_Load);
            this.panelHeader.ResumeLayout(false);
            this.grpScanner.ResumeLayout(false);
            this.grpScanner.PerformLayout();
            this.PanelStart.ResumeLayout(false);
            this.PanelStart.PerformLayout();
            this.PanelStop.ResumeLayout(false);
            this.PanelStop.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSlotNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPartCode;
        private System.Windows.Forms.TextBox txtScannerPort;
        private System.Windows.Forms.TextBox txtScannerIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblHardwareFailMessage;
        private System.Windows.Forms.TextBox TxtInspection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalOK;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadFailed;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader InspectionDateTime;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.ListView lvdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox PanelStop;
        private System.Windows.Forms.GroupBox PanelStart;
        private System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.TextBox TxUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxttPassword;
        private System.Windows.Forms.TextBox TxttUserId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label15;
        private Button btnstatus;
        private ComboBox cmbShift;
        private Label label16;
        private Label label17;
        private TextBox TxttDuplicate;
    }
}