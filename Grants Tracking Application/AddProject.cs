using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Grants_Tracking_Application
{
    public partial class AddProject : Form
    {
        Boolean boolVal;
        List<ApplicantDetails> PIDetails = new List<ApplicantDetails>();
        SqlConnection connection;
        public AddProject()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GTAdatabase"].ConnectionString);
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            groupBox1.Controls[1].Focus();

            txtprojecttitle_Leave(null, null);
            txtAgencyContactName_Leave(null, null);
            txtAgencyName_Leave(null, null);
            cmdProgram_Leave(null, null);
            txtAgencyContactName_Leave(null, null);
            masktxtURL_Leave(null, null);
            masktxtAgencyMail_Leave(null, null);

            //Match funds check
            txtMatchInCash.Enabled = chkMatchFunds.Checked;
            txtMatchInKind.Enabled = chkMatchFunds.Checked;

            //project/grant default status is pending
            cmbStatus.SelectedIndex = 2;
            cmbStatus.Enabled = false;

            //Add PI user control for adding multiple PIs if needed for one project/grant
            multiplePI appUC = new multiplePI();
            tabPage1.Controls.Add(appUC);
            tabPI.SelectedTab = tabPage1;
            appUC.lblAddPI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addPI_LinkClicked);
            //appUC.lblremovePI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removePI_LinkClicked);
            appUC.lblremovePI.Visible = false;

            //remove focus from first textbox
            SendKeys.Send("{TAB}");

        }

        //link button Clicked event to add multiple PIs
        private void addPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TabPage newpage = new TabPage("PI " + (tabPI.TabPages.Count + 1));
            tabPI.TabPages.Add(newpage);
            multiplePI appUC = new multiplePI();
            newpage.Controls.Add(appUC);
            tabPI.SelectedTab = newpage;
            appUC.lblAddPI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addPI_LinkClicked);
            appUC.lblremovePI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removePI_LinkClicked);

        }

        //link button Clicked event to remove multiple PIs
        private void removePI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Would you like to remove this tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tabPI.TabPages.Remove(tabPI.SelectedTab);
                tabPI.SelectedTab = tabPI.TabPages[tabPI.TabPages.Count - 1];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel?", "New Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                connection.Close();
            }
        }


        private void getApplicants()
        {
            //List<ApplicantDetails> PIDetails = new List<ApplicantDetails>();
            
            foreach(TabPage tPage in tabPI.TabPages)
            {
                String strPIfname = tPage.Controls[0].Controls[3].Text;
                String strPIlname = tPage.Controls[0].Controls[13].Text;
                String strdepartment = tPage.Controls[0].Controls[11].Text;
                String strPhone = Regex.Replace((tPage.Controls[0].Controls[9].Text.ToString()), @"[^\d]", "");
                String strEmail = tPage.Controls[0].Controls[7].Text;

                //PIDetails.Add(strapplicant,strProgram,Int32.Parse(strPhone),"EMAIL");
                ApplicantDetails details = new ApplicantDetails();
                details.PIfname = strPIfname;
                details.PIlname = strPIlname;
                details.department = strdepartment;
                details.Phone = long.Parse(strPhone);
                details.Email = strEmail;

                PIDetails.Add(details);
            }

        }

        private class ApplicantDetails
        {
            public string PIfname { set; get; }
            public string PIlname { set; get; }
            public string department { set; get; }
            public long Phone { set; get; }
            public string Email { set; get; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validation check
            //boolVal = false;
            //ValidateData();
            //lblError.Visible = boolVal;
            try
            {
                InsertPIDetailsToDB();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //if (!boolVal)
            //{
                
            //    try
            //    {

            //        //get list of applicant details
            //        getApplicants();

            //        //checking only applicants data
            //        if(PIDetails.Count > 0)
            //        {
            //            string query = string.Format("Insert into dbo.Project(PI_Firstname, PI_Lastname,PI_department,PI_Contact,PI_Email) " +
            //            "values('{0}','{1}',{2},{3},'{4}')", txtAgencyName.Text, txtprojecttitle.Text, txtCFDA.Text, masktxtAgencyPhone.Text, masktxtAgencyMail.Text, txtAgencyContactName.Text);
            //            using (SqlCommand cmd = new SqlCommand(query, connection))
            //            {
            //                int rows = cmd.ExecuteNonQuery();
            //            }

            //            MessageBox.Show("Agency added successfully !!", "Agency", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please give required Inputs", "Agency", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (SqlException ex)
            //    {
            //        Console.WriteLine(ex);
            //    }
                //finally
                //{
                //    connection.Close();
                //}
            //}
        }

        //Validation check
        private void Validation_Check(Control widgetName, bool isEmpty)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = widgetName.Parent.CreateGraphics();

            if (isEmpty)
            {
                formGraphics.FillRectangle(myBrush, new Rectangle(widgetName.Location.X - 2, widgetName.Location.Y - 2, widgetName.Width + 4, widgetName.Height + 4));
                //myBrush.Dispose();
                //formGraphics.Dispose();
                widgetName.Focus();
                boolVal = true;
            }
            else
            {
                myBrush.Color = Color.DarkSeaGreen;
                formGraphics.FillRectangle(myBrush, new Rectangle(widgetName.Location.X - 2, widgetName.Location.Y - 2, widgetName.Width + 4, widgetName.Height + 4));
            }
        }


        //Amount formatting in text box
        private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {
            string value = (sender as TextBox).Text.Replace(",", "");
            ulong ul;
            if (ulong.TryParse(value, out ul))
            {
                (sender as TextBox).TextChanged -= textAmount_TextChanged;
                (sender as TextBox).Text = string.Format("{0:#,#}", ul);
                (sender as TextBox).SelectionStart = this.Text.Length;
                (sender as TextBox).TextChanged += textAmount_TextChanged;
            }
        }

        private void chkMatchFunds_CheckedChanged(object sender, EventArgs e)
        {
            txtMatchInCash.Enabled = chkMatchFunds.Checked;
            txtMatchInKind.Enabled = chkMatchFunds.Checked;
        }

        #region WaterMark

        private void txtprojecttitle_Enter(object sender, EventArgs e)
        {
            if (txtprojecttitle.Text.Equals("Enter Project Title") == true)
            {
                txtprojecttitle.Text = "";
                txtprojecttitle.ForeColor = Color.Black;
            }
        }

        private void txtprojecttitle_Leave(object sender, EventArgs e)
        {
            if (txtprojecttitle.Text.Equals(null) == true || txtprojecttitle.Text.Equals("") == true)
            {
                txtprojecttitle.Text = "Enter Project Title";
                txtprojecttitle.ForeColor = Color.Gray;
            }
        }

        private void txtAgencyName_Enter(object sender, EventArgs e)
        {
            if (txtAgencyName.Text.Equals("Enter Agency Name") == true)
            {
                txtAgencyName.Text = "";
                txtAgencyName.ForeColor = Color.Black;
            }
        }

        private void txtAgencyName_Leave(object sender, EventArgs e)
        {
            if (txtAgencyName.Text.Equals(null) == true || txtAgencyName.Text.Equals("") == true)
            {
                txtAgencyName.Text = "Enter Agency Name";
                txtAgencyName.ForeColor = Color.Gray;
            }
        }

        private void cmdProgram_Enter(object sender, EventArgs e)
        {
            if (cmdProgram.Text.Equals("Enter Program Name") == true)
            {
                cmdProgram.Text = "";
                cmdProgram.ForeColor = Color.Black;
            }
        }

        private void cmdProgram_Leave(object sender, EventArgs e)
        {
            if (cmdProgram.Text.Equals(null) == true || cmdProgram.Text.Equals("") == true)
            {
                cmdProgram.Text = "Enter Program Name";
                cmdProgram.ForeColor = Color.Gray;
            }
        }

        private void txtAgencyContactName_Enter(object sender, EventArgs e)
        {
            if (txtAgencyContactName.Text.Equals("Enter Contact Name") == true)
            {
                txtAgencyContactName.Text = "";
                txtAgencyContactName.ForeColor = Color.Black;
            }
        }

        private void txtAgencyContactName_Leave(object sender, EventArgs e)
        {
            if (txtAgencyContactName.Text.Equals(null) == true || txtAgencyContactName.Text.Equals("") == true)
            {
                txtAgencyContactName.Text = "Enter Contact Name";
                txtAgencyContactName.ForeColor = Color.Gray;
            }
        }

        private void masktxtAgencyMail_Enter(object sender, EventArgs e)
        {
            if (masktxtAgencyMail.Text.Equals("Enter Agency Email") == true)
            {
                masktxtAgencyMail.Text = "";
                masktxtAgencyMail.ForeColor = Color.Black;
            }
        }

        private void masktxtAgencyMail_Leave(object sender, EventArgs e)
        {
            if (masktxtAgencyMail.Text.Equals(null) == true || masktxtAgencyMail.Text.Equals("") == true)
            {
                masktxtAgencyMail.Text = "Enter Agency Email";
                masktxtAgencyMail.ForeColor = Color.Gray;
            }
        }

        private void masktxtURL_Enter(object sender, EventArgs e)
        {
            if (masktxtURL.Text.Equals("Enter Agency URL") == true)
            {
                masktxtURL.Text = "";
                masktxtURL.ForeColor = Color.Black;
            }
        }

        private void masktxtURL_Leave(object sender, EventArgs e)
        {
            if (masktxtURL.Text.Equals(null) == true || masktxtURL.Text.Equals("") == true)
            {
                masktxtURL.Text = "Enter Agency URL";
                masktxtURL.ForeColor = Color.Gray;
            }
        }


        #endregion

        void ValidateData()
        {

            if (string.IsNullOrWhiteSpace(txtprojecttitle.Text.Trim()) || txtprojecttitle.Text.Trim().Contains("Enter"))
                Validation_Check(txtprojecttitle, true);
            else
                Validation_Check(txtprojecttitle, false);

            if (cmbProjectType.SelectedIndex < 0) Validation_Check(cmbProjectType, true);
            else
                Validation_Check(cmbProjectType, false);

            if (string.IsNullOrWhiteSpace(txtAgencyName.Text.Trim()) || txtAgencyName.Text.Trim().Contains("Enter"))
                Validation_Check(txtAgencyName, true);
            else
                Validation_Check(txtAgencyName, false);

            if (string.IsNullOrWhiteSpace(cmdProgram.Text.Trim()) || cmdProgram.Text.Trim().Contains("Enter"))
                Validation_Check(cmdProgram, true);
            else
                Validation_Check(cmdProgram, false);

            //if (string.IsNullOrWhiteSpace(txtAgencyContactName.Text.Trim()) || txtAgencyContactName.Text.Trim().Contains("Enter"))
            //    Validation_Check(txtAgencyContactName, true);
            //else
            //    Validation_Check(txtAgencyContactName, false);

            //if (string.IsNullOrWhiteSpace(txtCFDA.Text.Trim()) || txtCFDA.Text.Trim().Contains("Enter"))
            //    Validation_Check(txtCFDA, true);
            //else
            //    Validation_Check(txtCFDA, false);

            //if (string.IsNullOrWhiteSpace(masktxtAgencyMail.Text.Trim()) || masktxtAgencyMail.Text.Trim().Contains("Enter"))
            //    Validation_Check(masktxtAgencyMail, true);
            //else
            //    Validation_Check(masktxtAgencyMail, false);

            //if (string.IsNullOrWhiteSpace(masktxtURL.Text.Trim()) || masktxtURL.Text.Trim().Contains("Enter"))
            //    Validation_Check(masktxtURL, true);
            //else
            //    Validation_Check(masktxtURL, false);

            //masktxtAgencyPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //if (string.IsNullOrWhiteSpace(masktxtAgencyPhone.Text) || masktxtAgencyPhone.Text.Length != 10 || masktxtAgencyPhone.Text.Trim().Contains("Enter"))
            //    Validation_Check(masktxtAgencyPhone, true);
            //else Validation_Check(masktxtAgencyPhone, false);

        }
        /// <summary>
        /// Validating the Email is in correct format or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (sender != null && !((TextBox)sender).Text.Contains("Enter") && ((TextBox)sender).Text.Length > 0)
            {
                if (!rEMail.IsMatch(((TextBox)sender).Text))
                {
                    MessageBox.Show("E-Mail address expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Collecting data of pi details from all tabs
        /// </summary>
        /// <returns>string</returns>
        private string getPIDetails()
        {
            string piDetails = "";
            foreach (TabPage tPage in tabPI.TabPages)
            {
                foreach (Control uc in tPage.Controls.OfType<multiplePI>())
                {
                    List<Control> controls = ToControlsSorted(uc);

                    foreach (Control c in controls)
                    {
                        if (c is TextBox)
                        {
                            piDetails += c.Text + "+";
                        }
                        else if (c is MaskedTextBox)
                        {
                            ((MaskedTextBox)c).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            piDetails += ((MaskedTextBox)c).Text + "+";
                        }
                    }
                    piDetails = piDetails.TrimEnd('+');
                    piDetails += "\n";
                }


                //String strPIfname = tPage.Controls[0].Controls[3].Text;
                //String strPIlname = tPage.Controls[0].Controls[13].Text;
                //String strdepartment = tPage.Controls[0].Controls[11].Text;
                //String strPhone = Regex.Replace((tPage.Controls[0].Controls[9].Text.ToString()), @"[^\d]", "");
                //String strEmail = tPage.Controls[0].Controls[7].Text;
            }
            return piDetails;
        }
        //to get controls in order in multiple PI user control
        public List<Control> ToControlsSorted(Control control)
        {
            var controls = control.Controls.OfType<Control>().ToList();
            controls.Sort((c1, c2) => c1.TabIndex.CompareTo(c2.TabIndex));
            return controls;
        }
        /// <summary>
        /// Inserting Pi details into database table PI
        /// </summary>
        private void InsertPIDetailsToDB()
        {
            string piDetails = getPIDetails();
            string[] totalPIs = piDetails.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                connection.Open();
                foreach (var item in totalPIs)
                {
                    string[] details = item.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
                    string query = string.Format("Insert into dbo.PI(PI_Firstname, PI_Lastname,PI_department,PI_Contact,PI_Email) " +
                            "values('{0}','{1}','{2}','{3}','{4}')", details[0], details[1], details[2], details[3], details[4]);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int rows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private void ExceltoDataGrid()
        {
            string pathconn = "Provider = Microsoft.jet.OLEDB.4.0; Data source='C:\\Users\\S518669\\Desktop\\Project Docs\\_Proposals_MASTER.xlsx';Extended Properties=\"Excel 8.0;HDR= yes;\";";
            OleDbConnection conn = new OleDbConnection(pathconn);
            OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select * from [Master$]", conn);// Master Name of sheet in workbook
            DataTable dt = new DataTable();
            MyDataAdapter.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

    }
}