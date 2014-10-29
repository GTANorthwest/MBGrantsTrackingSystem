namespace Grants_Tracking_Application
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.msHome = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectGrantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPIApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAgencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agencyProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIApplicantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datebasedReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHome
            // 
            this.msHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.msHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msHome.Location = new System.Drawing.Point(0, 0);
            this.msHome.Name = "msHome";
            this.msHome.Size = new System.Drawing.Size(616, 27);
            this.msHome.TabIndex = 0;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectGrantToolStripMenuItem,
            this.newPIApplicantToolStripMenuItem,
            this.newAgencyToolStripMenuItem,
            this.importExportDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newProjectGrantToolStripMenuItem
            // 
            this.newProjectGrantToolStripMenuItem.Name = "newProjectGrantToolStripMenuItem";
            this.newProjectGrantToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.newProjectGrantToolStripMenuItem.Text = "New Project (Grant)";
            this.newProjectGrantToolStripMenuItem.Click += new System.EventHandler(this.newProjectGrantToolStripMenuItem_Click);
            // 
            // newPIApplicantToolStripMenuItem
            // 
            this.newPIApplicantToolStripMenuItem.Name = "newPIApplicantToolStripMenuItem";
            this.newPIApplicantToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.newPIApplicantToolStripMenuItem.Text = "New PI (Applicant)";
            this.newPIApplicantToolStripMenuItem.Click += new System.EventHandler(this.newPIApplicantToolStripMenuItem_Click);
            // 
            // newAgencyToolStripMenuItem
            // 
            this.newAgencyToolStripMenuItem.Name = "newAgencyToolStripMenuItem";
            this.newAgencyToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.newAgencyToolStripMenuItem.Text = "New Agency";
            this.newAgencyToolStripMenuItem.Click += new System.EventHandler(this.newAgencyToolStripMenuItem_Click);
            // 
            // importExportDataToolStripMenuItem
            // 
            this.importExportDataToolStripMenuItem.Name = "importExportDataToolStripMenuItem";
            this.importExportDataToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.importExportDataToolStripMenuItem.Text = "Import/ Export Data";
            this.importExportDataToolStripMenuItem.Click += new System.EventHandler(this.importExportDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.agencyProgramsToolStripMenuItem,
            this.pIApplicantsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.editToolStripMenuItem.Text = "View/Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.projectToolStripMenuItem.Text = "Project (Grants)";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // agencyProgramsToolStripMenuItem
            // 
            this.agencyProgramsToolStripMenuItem.Name = "agencyProgramsToolStripMenuItem";
            this.agencyProgramsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.agencyProgramsToolStripMenuItem.Text = "Agency/Programs";
            // 
            // pIApplicantsToolStripMenuItem
            // 
            this.pIApplicantsToolStripMenuItem.Name = "pIApplicantsToolStripMenuItem";
            this.pIApplicantsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.pIApplicantsToolStripMenuItem.Text = "PI (Applicants)";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportsToolStripMenuItem,
            this.annualReportsToolStripMenuItem,
            this.datebasedReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // monthlyReportsToolStripMenuItem
            // 
            this.monthlyReportsToolStripMenuItem.Name = "monthlyReportsToolStripMenuItem";
            this.monthlyReportsToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.monthlyReportsToolStripMenuItem.Text = "Monthly Reports ";
            // 
            // annualReportsToolStripMenuItem
            // 
            this.annualReportsToolStripMenuItem.Name = "annualReportsToolStripMenuItem";
            this.annualReportsToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.annualReportsToolStripMenuItem.Text = "Annual Reports";
            // 
            // datebasedReportsToolStripMenuItem
            // 
            this.datebasedReportsToolStripMenuItem.Name = "datebasedReportsToolStripMenuItem";
            this.datebasedReportsToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.datebasedReportsToolStripMenuItem.Text = "Date-based Reports";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grants_Tracking_Application.Properties.Resources.Homedesign;
            this.ClientSize = new System.Drawing.Size(616, 343);
            this.Controls.Add(this.msHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msHome;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grants Tracking Application";
            this.msHome.ResumeLayout(false);
            this.msHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msHome;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectGrantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPIApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAgencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agencyProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIApplicantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datebasedReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

