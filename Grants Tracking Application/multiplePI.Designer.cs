namespace Grants_Tracking_Application
{
    partial class multiplePI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAddPI = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.MasktxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPILastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblremovePI = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPIFirstname = new System.Windows.Forms.TextBox();
            this.masktxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmand01 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddPI
            // 
            this.lblAddPI.AutoSize = true;
            this.lblAddPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPI.LinkColor = System.Drawing.Color.Snow;
            this.lblAddPI.Location = new System.Drawing.Point(291, 4);
            this.lblAddPI.Name = "lblAddPI";
            this.lblAddPI.Size = new System.Drawing.Size(46, 13);
            this.lblAddPI.TabIndex = 5;
            this.lblAddPI.TabStop = true;
            this.lblAddPI.Text = "add >>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // MasktxtPhone
            // 
            this.MasktxtPhone.Location = new System.Drawing.Point(96, 104);
            this.MasktxtPhone.Mask = "(999) 000-0000";
            this.MasktxtPhone.Name = "MasktxtPhone";
            this.MasktxtPhone.Size = new System.Drawing.Size(86, 20);
            this.MasktxtPhone.TabIndex = 3;
            this.toolTip1.SetToolTip(this.MasktxtPhone, "Enter PI Phone No");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(96, 77);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(222, 20);
            this.txtDepartment.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDepartment, "Enter Dept Name");
            this.txtDepartment.Enter += new System.EventHandler(this.txtDepartment_Enter);
            this.txtDepartment.Leave += new System.EventHandler(this.txtDepartment_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department";
            // 
            // txtPILastname
            // 
            this.txtPILastname.Location = new System.Drawing.Point(96, 25);
            this.txtPILastname.Name = "txtPILastname";
            this.txtPILastname.Size = new System.Drawing.Size(222, 20);
            this.txtPILastname.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtPILastname, "Enter PI lastname");
            this.txtPILastname.TextChanged += new System.EventHandler(this.txtApplicant_TextChanged);
            this.txtPILastname.Enter += new System.EventHandler(this.txtApplicant_Enter);
            this.txtPILastname.Leave += new System.EventHandler(this.txtApplicant_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lastname";
            // 
            // lblremovePI
            // 
            this.lblremovePI.AutoSize = true;
            this.lblremovePI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremovePI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblremovePI.LinkColor = System.Drawing.Color.White;
            this.lblremovePI.Location = new System.Drawing.Point(6, 4);
            this.lblremovePI.Name = "lblremovePI";
            this.lblremovePI.Size = new System.Drawing.Size(66, 13);
            this.lblremovePI.TabIndex = 6;
            this.lblremovePI.TabStop = true;
            this.lblremovePI.Text = "<< remove";
            // 
            // txtPIFirstname
            // 
            this.txtPIFirstname.Location = new System.Drawing.Point(96, 51);
            this.txtPIFirstname.Name = "txtPIFirstname";
            this.txtPIFirstname.Size = new System.Drawing.Size(222, 20);
            this.txtPIFirstname.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPIFirstname, "Enter PI firstname");
            this.txtPIFirstname.Enter += new System.EventHandler(this.txtPIFirstname_Enter);
            this.txtPIFirstname.Leave += new System.EventHandler(this.txtPIFirstname_Leave);
            // 
            // masktxtEmail
            // 
            this.masktxtEmail.Location = new System.Drawing.Point(96, 131);
            this.masktxtEmail.Name = "masktxtEmail";
            this.masktxtEmail.Size = new System.Drawing.Size(222, 20);
            this.masktxtEmail.TabIndex = 4;
            this.toolTip1.SetToolTip(this.masktxtEmail, "Enter PI Email");
            this.masktxtEmail.Enter += new System.EventHandler(this.masktxtEmail_Enter);
            this.masktxtEmail.Leave += new System.EventHandler(this.masktxtEmail_Leave);
            this.masktxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firstname";
            // 
            // lblmand01
            // 
            this.lblmand01.AutoSize = true;
            this.lblmand01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmand01.ForeColor = System.Drawing.Color.Red;
            this.lblmand01.Location = new System.Drawing.Point(77, 28);
            this.lblmand01.Name = "lblmand01";
            this.lblmand01.Size = new System.Drawing.Size(16, 20);
            this.lblmand01.TabIndex = 12;
            this.lblmand01.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(77, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // multiplePI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.masktxtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmand01);
            this.Controls.Add(this.txtPIFirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblremovePI);
            this.Controls.Add(this.lblAddPI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MasktxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPILastname);
            this.Controls.Add(this.label3);
            this.Name = "multiplePI";
            this.Size = new System.Drawing.Size(342, 160);
            this.Load += new System.EventHandler(this.multiplePI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel lblAddPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MasktxtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPILastname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.LinkLabel lblremovePI;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPIFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmand01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox masktxtEmail;
    }
}
