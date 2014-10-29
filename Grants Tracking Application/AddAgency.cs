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

namespace Grants_Tracking_Application
{
    public partial class AddAgency : Form
    {
        public AddAgency()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GTAdatabase"].ConnectionString);
            try
            {
                connection.Open();
                if (txtAgencyName.Text != "" ||
                    txtProgramName.Text != "" || txtCFDA.Text != "" ||
                   // masktxtAgencyPhone.Text != ""  || 
                    masktxtAgencyMail.Text != "" || 
                    txtAgencyContactName.Text != "")
                {
                    
                    string query = string.Format("Insert into dbo.Agency(agencyName, programName,CFDA,agencyContact,agencyEmail,agencyContactName) " +
                    "values('{0}','{1}',{2},{3},'{4}','{5}')", txtAgencyName.Text, txtProgramName.Text, txtCFDA.Text, masktxtAgencyPhone.Text, masktxtAgencyMail.Text, txtAgencyContactName.Text);
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int rows = cmd.ExecuteNonQuery();
                    }
                   
                    MessageBox.Show("Agency added successfully !!", "Agency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please give required Inputs", "Agency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
