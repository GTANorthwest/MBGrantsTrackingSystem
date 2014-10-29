namespace Grants_Tracking_Application
{
    partial class AddAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAgency));
            this.masktxtURL = new System.Windows.Forms.MaskedTextBox();
            this.lblAgencyURL = new System.Windows.Forms.Label();
            this.txtAgencyContactName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCFDA = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.masktxtAgencyMail = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.masktxtAgencyPhone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // masktxtURL
            // 
            this.masktxtURL.Location = new System.Drawing.Point(103, 164);
            this.masktxtURL.Name = "masktxtURL";
            this.masktxtURL.Size = new System.Drawing.Size(227, 20);
            this.masktxtURL.TabIndex = 57;
            // 
            // lblAgencyURL
            // 
            this.lblAgencyURL.AutoSize = true;
            this.lblAgencyURL.Location = new System.Drawing.Point(59, 168);
            this.lblAgencyURL.Name = "lblAgencyURL";
            this.lblAgencyURL.Size = new System.Drawing.Size(29, 13);
            this.lblAgencyURL.TabIndex = 56;
            this.lblAgencyURL.Text = "URL";
            // 
            // txtAgencyContactName
            // 
            this.txtAgencyContactName.Location = new System.Drawing.Point(103, 79);
            this.txtAgencyContactName.Name = "txtAgencyContactName";
            this.txtAgencyContactName.Size = new System.Drawing.Size(227, 20);
            this.txtAgencyContactName.TabIndex = 55;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 54;
            this.label26.Text = "Contact Name";
            // 
            // txtCFDA
            // 
            this.txtCFDA.Location = new System.Drawing.Point(261, 108);
            this.txtCFDA.Name = "txtCFDA";
            this.txtCFDA.Size = new System.Drawing.Size(69, 20);
            this.txtCFDA.TabIndex = 53;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(220, 112);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 52;
            this.label32.Text = "CFDA";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(43, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "Program";
            // 
            // masktxtAgencyMail
            // 
            this.masktxtAgencyMail.Location = new System.Drawing.Point(103, 135);
            this.masktxtAgencyMail.Name = "masktxtAgencyMail";
            this.masktxtAgencyMail.Size = new System.Drawing.Size(227, 20);
            this.masktxtAgencyMail.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Email";
            // 
            // masktxtAgencyPhone
            // 
            this.masktxtAgencyPhone.Location = new System.Drawing.Point(103, 107);
            this.masktxtAgencyPhone.Mask = "(999) 000-0000";
            this.masktxtAgencyPhone.Name = "masktxtAgencyPhone";
            this.masktxtAgencyPhone.Size = new System.Drawing.Size(89, 20);
            this.masktxtAgencyPhone.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Phone";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(103, 22);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(227, 20);
            this.txtAgencyName.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Agency Name";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(165, 202);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(75, 23);
            this.txtAdd.TabIndex = 58;
            this.txtAdd.Text = "Add";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(103, 51);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(227, 20);
            this.txtProgramName.TabIndex = 60;
            // 
            // AddAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(351, 243);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.masktxtURL);
            this.Controls.Add(this.lblAgencyURL);
            this.Controls.Add(this.txtAgencyContactName);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtCFDA);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.masktxtAgencyMail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.masktxtAgencyPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAgencyName);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAgency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masktxtURL;
        private System.Windows.Forms.Label lblAgencyURL;
        private System.Windows.Forms.TextBox txtAgencyContactName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCFDA;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox masktxtAgencyMail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox masktxtAgencyPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProgramName;
    }
}