namespace Grants_Tracking_Application
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.grpMatchAmount = new System.Windows.Forms.GroupBox();
            this.txtMatchInCash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMatchInKind = new System.Windows.Forms.TextBox();
            this.chkMatchFunds = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpRequestAmount = new System.Windows.Forms.GroupBox();
            this.txtRequestInCash = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRequestInKind = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMiscNotes = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPI = new System.Windows.Forms.TabControl();
            this.lblAllowedCOst = new System.Windows.Forms.Label();
            this.txtAgencyContactName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCFDA = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cmdProgram = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.masktxtURL = new System.Windows.Forms.TextBox();
            this.masktxtAgencyMail = new System.Windows.Forms.TextBox();
            this.lblAgencyURL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.masktxtAgencyPhone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalProjectAmount = new System.Windows.Forms.TextBox();
            this.lblProjectCost = new System.Windows.Forms.Label();
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.txtprojecttitle = new System.Windows.Forms.TextBox();
            this.lblprojecttype = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmand01 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtallowedDirectCost = new System.Windows.Forms.TextBox();
            this.dateSubmitted = new System.Windows.Forms.DateTimePicker();
            this.dateProposal = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpMatchAmount.SuspendLayout();
            this.grpRequestAmount.SuspendLayout();
            this.tabPI.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMatchAmount
            // 
            this.grpMatchAmount.Controls.Add(this.txtMatchInCash);
            this.grpMatchAmount.Controls.Add(this.label7);
            this.grpMatchAmount.Controls.Add(this.label20);
            this.grpMatchAmount.Controls.Add(this.txtMatchInKind);
            this.grpMatchAmount.Controls.Add(this.chkMatchFunds);
            this.grpMatchAmount.Controls.Add(this.label21);
            this.grpMatchAmount.Controls.Add(this.label22);
            this.grpMatchAmount.Location = new System.Drawing.Point(18, 198);
            this.grpMatchAmount.Name = "grpMatchAmount";
            this.grpMatchAmount.Size = new System.Drawing.Size(345, 56);
            this.grpMatchAmount.TabIndex = 25;
            this.grpMatchAmount.TabStop = false;
            this.grpMatchAmount.Text = "Match";
            // 
            // txtMatchInCash
            // 
            this.txtMatchInCash.Location = new System.Drawing.Point(74, 20);
            this.txtMatchInCash.Name = "txtMatchInCash";
            this.txtMatchInCash.Size = new System.Drawing.Size(90, 20);
            this.txtMatchInCash.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtMatchInCash, "Match Funds Cash");
            this.txtMatchInCash.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            this.txtMatchInCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "( in Cash )";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(62, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "$";
            // 
            // txtMatchInKind
            // 
            this.txtMatchInKind.Location = new System.Drawing.Point(247, 20);
            this.txtMatchInKind.Name = "txtMatchInKind";
            this.txtMatchInKind.Size = new System.Drawing.Size(90, 20);
            this.txtMatchInKind.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtMatchInKind, "Match Funds Kind");
            this.txtMatchInKind.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            this.txtMatchInKind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // chkMatchFunds
            // 
            this.chkMatchFunds.AutoSize = true;
            this.chkMatchFunds.Location = new System.Drawing.Point(9, -1);
            this.chkMatchFunds.Name = "chkMatchFunds";
            this.chkMatchFunds.Size = new System.Drawing.Size(88, 17);
            this.chkMatchFunds.TabIndex = 25;
            this.chkMatchFunds.Text = "Match Funds";
            this.chkMatchFunds.UseVisualStyleBackColor = true;
            this.chkMatchFunds.CheckedChanged += new System.EventHandler(this.chkMatchFunds_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(183, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "( in Kind )";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(235, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "$";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PI 1";
            // 
            // grpRequestAmount
            // 
            this.grpRequestAmount.Controls.Add(this.txtRequestInCash);
            this.grpRequestAmount.Controls.Add(this.label16);
            this.grpRequestAmount.Controls.Add(this.label17);
            this.grpRequestAmount.Controls.Add(this.txtRequestInKind);
            this.grpRequestAmount.Controls.Add(this.label19);
            this.grpRequestAmount.Controls.Add(this.label18);
            this.grpRequestAmount.Location = new System.Drawing.Point(18, 138);
            this.grpRequestAmount.Name = "grpRequestAmount";
            this.grpRequestAmount.Size = new System.Drawing.Size(345, 51);
            this.grpRequestAmount.TabIndex = 23;
            this.grpRequestAmount.TabStop = false;
            this.grpRequestAmount.Text = "Request";
            // 
            // txtRequestInCash
            // 
            this.txtRequestInCash.Location = new System.Drawing.Point(73, 17);
            this.txtRequestInCash.Name = "txtRequestInCash";
            this.txtRequestInCash.Size = new System.Drawing.Size(90, 20);
            this.txtRequestInCash.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtRequestInCash, "Request Cash");
            this.txtRequestInCash.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            this.txtRequestInCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "( in Cash )";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "$";
            // 
            // txtRequestInKind
            // 
            this.txtRequestInKind.Location = new System.Drawing.Point(246, 17);
            this.txtRequestInKind.Name = "txtRequestInKind";
            this.txtRequestInKind.Size = new System.Drawing.Size(90, 20);
            this.txtRequestInKind.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtRequestInKind, "Request Kind");
            this.txtRequestInKind.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            this.txtRequestInKind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(182, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "( in Kind )";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(234, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "$";
            // 
            // txtMiscNotes
            // 
            this.txtMiscNotes.Location = new System.Drawing.Point(87, 352);
            this.txtMiscNotes.Multiline = true;
            this.txtMiscNotes.Name = "txtMiscNotes";
            this.txtMiscNotes.Size = new System.Drawing.Size(269, 100);
            this.txtMiscNotes.TabIndex = 30;
            this.toolTip1.SetToolTip(this.txtMiscNotes, "Miscellaneous Notes");
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 354);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 13);
            this.label31.TabIndex = 60;
            this.label31.Text = "Misc. Notes";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 13;
            this.cmbStatus.Items.AddRange(new object[] {
            "Unfunded",
            "Funded",
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(297, 23);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(71, 21);
            this.cmbStatus.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cmbStatus, "Project Status");
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(259, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 56;
            this.label30.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Submitted Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Start Date";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(17, 488);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(259, 17);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "** highlighted fields are mandatory";
            this.lblError.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(661, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Proposal Due Date";
            // 
            // tabPI
            // 
            this.tabPI.Controls.Add(this.tabPage1);
            this.tabPI.Location = new System.Drawing.Point(8, 101);
            this.tabPI.Name = "tabPI";
            this.tabPI.SelectedIndex = 0;
            this.tabPI.Size = new System.Drawing.Size(348, 181);
            this.tabPI.TabIndex = 22;
            // 
            // lblAllowedCOst
            // 
            this.lblAllowedCOst.AutoSize = true;
            this.lblAllowedCOst.Location = new System.Drawing.Point(20, 54);
            this.lblAllowedCOst.Name = "lblAllowedCOst";
            this.lblAllowedCOst.Size = new System.Drawing.Size(99, 13);
            this.lblAllowedCOst.TabIndex = 64;
            this.lblAllowedCOst.Text = "Allowed Direct Cost";
            // 
            // txtAgencyContactName
            // 
            this.txtAgencyContactName.Location = new System.Drawing.Point(104, 82);
            this.txtAgencyContactName.Name = "txtAgencyContactName";
            this.txtAgencyContactName.Size = new System.Drawing.Size(210, 20);
            this.txtAgencyContactName.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtAgencyContactName, "Enter Contact Name");
            this.txtAgencyContactName.Enter += new System.EventHandler(this.txtAgencyContactName_Enter);
            this.txtAgencyContactName.Leave += new System.EventHandler(this.txtAgencyContactName_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 86);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Contact Name";
            // 
            // txtCFDA
            // 
            this.txtCFDA.Location = new System.Drawing.Point(249, 111);
            this.txtCFDA.Name = "txtCFDA";
            this.txtCFDA.Size = new System.Drawing.Size(65, 20);
            this.txtCFDA.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtCFDA, "Enter CFDA No");
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(208, 115);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 38;
            this.label32.Text = "CFDA";
            // 
            // cmdProgram
            // 
            this.cmdProgram.FormattingEnabled = true;
            this.cmdProgram.ItemHeight = 13;
            this.cmdProgram.Location = new System.Drawing.Point(104, 53);
            this.cmdProgram.Name = "cmdProgram";
            this.cmdProgram.Size = new System.Drawing.Size(210, 21);
            this.cmdProgram.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmdProgram, "Enter Program Name");
            this.cmdProgram.Enter += new System.EventHandler(this.cmdProgram_Enter);
            this.cmdProgram.Leave += new System.EventHandler(this.cmdProgram_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(44, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 29;
            this.label23.Text = "Program";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.masktxtURL);
            this.groupBox4.Controls.Add(this.masktxtAgencyMail);
            this.groupBox4.Controls.Add(this.lblAgencyURL);
            this.groupBox4.Controls.Add(this.txtAgencyContactName);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtCFDA);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.cmdProgram);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.masktxtAgencyPhone);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtAgencyName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 198);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agency Details";
            // 
            // masktxtURL
            // 
            this.masktxtURL.Location = new System.Drawing.Point(104, 168);
            this.masktxtURL.Name = "masktxtURL";
            this.masktxtURL.Size = new System.Drawing.Size(210, 20);
            this.masktxtURL.TabIndex = 17;
            this.toolTip1.SetToolTip(this.masktxtURL, "Enter Contact Name");
            this.masktxtURL.Enter += new System.EventHandler(this.masktxtURL_Enter);
            this.masktxtURL.Leave += new System.EventHandler(this.masktxtURL_Leave);
            // 
            // masktxtAgencyMail
            // 
            this.masktxtAgencyMail.Location = new System.Drawing.Point(104, 139);
            this.masktxtAgencyMail.Name = "masktxtAgencyMail";
            this.masktxtAgencyMail.Size = new System.Drawing.Size(210, 20);
            this.masktxtAgencyMail.TabIndex = 16;
            this.toolTip1.SetToolTip(this.masktxtAgencyMail, "Enter Contact Name");
            this.masktxtAgencyMail.Enter += new System.EventHandler(this.masktxtAgencyMail_Enter);
            this.masktxtAgencyMail.Leave += new System.EventHandler(this.masktxtAgencyMail_Leave);
            this.masktxtAgencyMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblAgencyURL
            // 
            this.lblAgencyURL.AutoSize = true;
            this.lblAgencyURL.Location = new System.Drawing.Point(60, 171);
            this.lblAgencyURL.Name = "lblAgencyURL";
            this.lblAgencyURL.Size = new System.Drawing.Size(29, 13);
            this.lblAgencyURL.TabIndex = 42;
            this.lblAgencyURL.Text = "URL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Email";
            // 
            // masktxtAgencyPhone
            // 
            this.masktxtAgencyPhone.Location = new System.Drawing.Point(104, 110);
            this.masktxtAgencyPhone.Mask = "(999) 000-0000";
            this.masktxtAgencyPhone.Name = "masktxtAgencyPhone";
            this.masktxtAgencyPhone.Size = new System.Drawing.Size(84, 20);
            this.masktxtAgencyPhone.TabIndex = 14;
            this.toolTip1.SetToolTip(this.masktxtAgencyPhone, "Enter Phone No");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Phone";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(104, 25);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(210, 20);
            this.txtAgencyName.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtAgencyName, "Enter Agency Name");
            this.txtAgencyName.Enter += new System.EventHandler(this.txtAgencyName_Enter);
            this.txtAgencyName.Leave += new System.EventHandler(this.txtAgencyName_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Agency Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(87, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 20);
            this.label25.TabIndex = 47;
            this.label25.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(87, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "*";
            // 
            // txttotalProjectAmount
            // 
            this.txttotalProjectAmount.Location = new System.Drawing.Point(134, 24);
            this.txttotalProjectAmount.Name = "txttotalProjectAmount";
            this.txttotalProjectAmount.Size = new System.Drawing.Size(117, 20);
            this.txttotalProjectAmount.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txttotalProjectAmount, "Project Total Cost");
            this.txttotalProjectAmount.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            this.txttotalProjectAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // lblProjectCost
            // 
            this.lblProjectCost.AutoSize = true;
            this.lblProjectCost.Location = new System.Drawing.Point(6, 28);
            this.lblProjectCost.Name = "lblProjectCost";
            this.lblProjectCost.Size = new System.Drawing.Size(106, 13);
            this.lblProjectCost.TabIndex = 23;
            this.lblProjectCost.Text = "Total Project Amount";
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Items.AddRange(new object[] {
            "Capital Project",
            "Equipment Purchase",
            "Research",
            "Student fellowship or Scholarship",
            "WorkShop or Conference",
            "Others"});
            this.cmbProjectType.Location = new System.Drawing.Point(105, 50);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(211, 21);
            this.cmbProjectType.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmbProjectType, "Enter Project Type");
            // 
            // txtprojecttitle
            // 
            this.txtprojecttitle.Location = new System.Drawing.Point(105, 20);
            this.txtprojecttitle.Name = "txtprojecttitle";
            this.txtprojecttitle.Size = new System.Drawing.Size(211, 20);
            this.txtprojecttitle.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtprojecttitle, "Enter Project Title");
            this.txtprojecttitle.Enter += new System.EventHandler(this.txtprojecttitle_Enter);
            this.txtprojecttitle.Leave += new System.EventHandler(this.txtprojecttitle_Leave);
            // 
            // lblprojecttype
            // 
            this.lblprojecttype.AutoSize = true;
            this.lblprojecttype.Location = new System.Drawing.Point(23, 54);
            this.lblprojecttype.Name = "lblprojecttype";
            this.lblprojecttype.Size = new System.Drawing.Size(67, 13);
            this.lblprojecttype.TabIndex = 12;
            this.lblprojecttype.Text = "Project Type";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Location = new System.Drawing.Point(27, 24);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(63, 13);
            this.lblProjectTitle.TabIndex = 11;
            this.lblProjectTitle.Text = "Project Title";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(566, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Submit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblmand01);
            this.groupBox1.Controls.Add(this.cmbProjectType);
            this.groupBox1.Controls.Add(this.txtprojecttitle);
            this.groupBox1.Controls.Add(this.lblprojecttype);
            this.groupBox1.Controls.Add(this.lblProjectTitle);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project (Grant)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "*";
            // 
            // lblmand01
            // 
            this.lblmand01.AutoSize = true;
            this.lblmand01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmand01.ForeColor = System.Drawing.Color.Red;
            this.lblmand01.Location = new System.Drawing.Point(87, 21);
            this.lblmand01.Name = "lblmand01";
            this.lblmand01.Size = new System.Drawing.Size(16, 20);
            this.lblmand01.TabIndex = 15;
            this.lblmand01.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(118, 54);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "$";
            // 
            // txtallowedDirectCost
            // 
            this.txtallowedDirectCost.Location = new System.Drawing.Point(134, 50);
            this.txtallowedDirectCost.Name = "txtallowedDirectCost";
            this.txtallowedDirectCost.Size = new System.Drawing.Size(117, 20);
            this.txtallowedDirectCost.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtallowedDirectCost, "Project Allowed Direct Cost");
            this.txtallowedDirectCost.TextChanged += new System.EventHandler(this.textAmount_TextChanged);
            this.txtallowedDirectCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
            // 
            // dateSubmitted
            // 
            this.dateSubmitted.CustomFormat = "MMM-dd-yyyy";
            this.dateSubmitted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSubmitted.Location = new System.Drawing.Point(119, 311);
            this.dateSubmitted.Name = "dateSubmitted";
            this.dateSubmitted.Size = new System.Drawing.Size(102, 20);
            this.dateSubmitted.TabIndex = 29;
            this.toolTip1.SetToolTip(this.dateSubmitted, "Project Submitted Date");
            // 
            // dateProposal
            // 
            this.dateProposal.CustomFormat = "MMM-dd-yyyy";
            this.dateProposal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateProposal.Location = new System.Drawing.Point(119, 277);
            this.dateProposal.Name = "dateProposal";
            this.dateProposal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateProposal.Size = new System.Drawing.Size(102, 20);
            this.dateProposal.TabIndex = 28;
            this.toolTip1.SetToolTip(this.dateProposal, "Project Due Date");
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "MMM-dd-yyyy";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(263, 94);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(101, 20);
            this.dateEnd.TabIndex = 22;
            this.toolTip1.SetToolTip(this.dateEnd, "End Date of Project");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateSubmitted);
            this.groupBox3.Controls.Add(this.dateProposal);
            this.groupBox3.Controls.Add(this.dateEnd);
            this.groupBox3.Controls.Add(this.dateStart);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtallowedDirectCost);
            this.groupBox3.Controls.Add(this.lblAllowedCOst);
            this.groupBox3.Controls.Add(this.grpMatchAmount);
            this.groupBox3.Controls.Add(this.grpRequestAmount);
            this.groupBox3.Controls.Add(this.txtMiscNotes);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.cmbStatus);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txttotalProjectAmount);
            this.groupBox3.Controls.Add(this.lblProjectCost);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Location = new System.Drawing.Point(362, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 474);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project (Grant) Details";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "MMM-dd-yyyy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(78, 94);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(99, 20);
            this.dateStart.TabIndex = 21;
            this.toolTip1.SetToolTip(this.dateStart, "Start Date of Project");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(108, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 20);
            this.label27.TabIndex = 73;
            this.label27.Text = "*";
            // 
            // AddProject
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(749, 522);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabPI);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Project (Grant)";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.grpMatchAmount.ResumeLayout(false);
            this.grpMatchAmount.PerformLayout();
            this.grpRequestAmount.ResumeLayout(false);
            this.grpRequestAmount.PerformLayout();
            this.tabPI.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMatchAmount;
        private System.Windows.Forms.TextBox txtMatchInCash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMatchInKind;
        private System.Windows.Forms.CheckBox chkMatchFunds;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpRequestAmount;
        private System.Windows.Forms.TextBox txtRequestInCash;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRequestInKind;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMiscNotes;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabPI;
        private System.Windows.Forms.Label lblAllowedCOst;
        private System.Windows.Forms.TextBox txtAgencyContactName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCFDA;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cmdProgram;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox masktxtAgencyPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotalProjectAmount;
        private System.Windows.Forms.Label lblProjectCost;
        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.TextBox txtprojecttitle;
        private System.Windows.Forms.Label lblprojecttype;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtallowedDirectCost;
        private System.Windows.Forms.DateTimePicker dateSubmitted;
        private System.Windows.Forms.DateTimePicker dateProposal;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblAgencyURL;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox masktxtURL;
        private System.Windows.Forms.TextBox masktxtAgencyMail;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmand01;
        private System.Windows.Forms.Label label27;
    }
}