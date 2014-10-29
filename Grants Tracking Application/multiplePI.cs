using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grants_Tracking_Application
{
    public partial class multiplePI : UserControl
    {
        public multiplePI()
        {
            InitializeComponent();


            //for Applicant intellisense
            String[] strApplicant = { "Tye Parsons", "Ajay Bandi", "Anvesh", "Niharika", "Bharadwaj", "Arpita", "Shiva", "Chaitanya", "Gouthami", "Rupa", "Vikram" };
            txtPILastname.AutoCompleteCustomSource.AddRange(strApplicant);
            txtPILastname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPILastname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //for department intellisense
            String[] strDepartment = { "University Police", "CS/IS", "Natural Sciences", "Leet Center", "Business", "KXCV-KRNW", "Agricultural Sciences", "Grants, Finance", "Mathematics, Computer Science & InformationS" };
            txtDepartment.AutoCompleteCustomSource.AddRange(strDepartment);
            txtDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void multiplePI_Load(object sender, EventArgs e)
        {
            
            txtApplicant_Leave(null, null);
            txtPIFirstname_Leave(null, null);
            txtDepartment_Leave(null, null);
            masktxtEmail_Leave(null, null);
            SendKeys.Send("{ESC}");

        }

        private void txtApplicant_TextChanged(object sender, EventArgs e)
        {
            if (txtPILastname.Text == "Tye Parsons")
            {
                txtDepartment.Text = "Grants, Finance";
                //txtAmount.Text = "50000";
                masktxtEmail.Text = "parsons@nwmissouri.edu";
                MasktxtPhone.Text = "6605621147";
            }
            else if (txtPILastname.Text == "Ajay Bandi")
            {
                txtDepartment.Text = "Mathematics, Computer Science & InformationS";
                // txtAmount.Text = "35000";
                masktxtEmail.Text = "ajay@nwmissouri.edu";
                MasktxtPhone.Text = "6605621284";
            }
            //else if (txtApplicant.Text=="")
            //{
            //    //txtDepartment.Text = "";
            //    //masktxtEmail.Text = "";
            //    //MasktxtPhone.Text = "";
            //    txtApplicant_Leave(null, null);
            //    txtDepartment_Leave(null, null);
            //    masktxtEmail_Leave(null, null);
            //    SendKeys.Send("{ESC}");

            //}
        }

        private void txtApplicant_Enter(object sender, EventArgs e)
        {

            if (txtPILastname.Text.Equals("Enter PI LastName") == true)
            {
                txtPILastname.Text = "";
                txtPILastname.ForeColor = Color.Black;
            }
        }

        private void txtApplicant_Leave(object sender, EventArgs e)
        {
            txtPILastname.Enter -= txtApplicant_Enter;
            if (txtPILastname.Text.Equals(null) == true || txtPILastname.Text.Equals("") == true)
            {
                txtPILastname.Text = "Enter PI LastName";
                txtPILastname.ForeColor = Color.Gray;
            }
            txtPILastname.Enter += txtApplicant_Enter;
        }

        private void txtDepartment_Enter(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Equals("Enter Dept Name") == true)
            {
                txtDepartment.Text = "";
                txtDepartment.ForeColor = Color.Black;
            }
        }

        private void txtPIFirstname_Enter(object sender, EventArgs e)
        {
            if (txtPIFirstname.Text.Equals("Enter PI FirstName") == true)
            {
                txtPIFirstname.Text = "";
                txtPIFirstname.ForeColor = Color.Black;
            }
        }

        private void txtPIFirstname_Leave(object sender, EventArgs e)
        {
            txtPIFirstname.Enter -= txtPIFirstname_Enter;
            if (txtPIFirstname.Text.Equals(null) == true || txtPIFirstname.Text.Equals("") == true)
            {
                txtPIFirstname.Text = "Enter PI FirstName";
                txtPIFirstname.ForeColor = Color.Gray;
            }
            txtPIFirstname.Enter += txtPIFirstname_Enter;
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            txtDepartment.Enter -= txtDepartment_Enter;
            if (txtDepartment.Text.Equals(null) == true || txtDepartment.Text.Equals("") == true)
            {
                txtDepartment.Text = "Enter Dept Name";
                txtDepartment.ForeColor = Color.Gray;
            }
            txtDepartment.Enter += txtDepartment_Enter;
        }

        private void masktxtEmail_Enter(object sender, EventArgs e)
        {
            if (masktxtEmail.Text.Equals("Enter PI Email") == true)
            {
                masktxtEmail.Text = "";
                masktxtEmail.ForeColor = Color.Black;
            }
        }

        private void masktxtEmail_Leave(object sender, EventArgs e)
        {
            masktxtEmail.Enter -= masktxtEmail_Enter;
            if (masktxtEmail.Text.Equals(null) == true || masktxtEmail.Text.Equals("") == true)
            {
                masktxtEmail.Text = "Enter PI Email";
                masktxtEmail.ForeColor = Color.Gray;
            }
            masktxtEmail.Enter += masktxtEmail_Enter;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (sender != null && !((TextBox)sender).Text.Contains("Enter") && ((TextBox)sender).Text.Length > 0)
            {
                if (!rEMail.IsMatch(((TextBox)sender).Text))
                {
                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

       

    }
}
