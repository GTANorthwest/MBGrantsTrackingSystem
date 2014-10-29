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
    public partial class AddPI : Form
    {
        public AddPI()
        {
            InitializeComponent();

            //for Applicant intellisense
            String[] strApplicant = { "Tye Parsons", "Ajay Bandi", "Anvesh", "Niharika", "Bharadwaj", "Arpita", "Shiva", "Chaitanya", "Gouthami", "Rupa", "Vikram" };
            txtApplicant.AutoCompleteCustomSource.AddRange(strApplicant);
            txtApplicant.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtApplicant.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //for department intellisense
            String[] strDepartment = { "University Police", "CS/IS", "Natural Sciences", "Leet Center", "Business", "KXCV-KRNW", "Agricultural Sciences", "Grants, Finance", "Mathematics, Computer Science & InformationS" };
            txtDepartment.AutoCompleteCustomSource.AddRange(strDepartment);
            txtDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            //try
            //{
            //    connection.Open();
            //    if (true)
            //    {
            //        //SqlCommand cmd = new SqlCommand(String.Format("Insert into boron.BharadwajM.dbo.Agency(agencyName, programName,CFDA,agencyContact,agencyEmail,agencyContactName) "+
            //        //"values('{0}','{1}','{2}','{3}','{4}','{5}')", txtAgencyName.Text, txtProgramName.Text, txtCFDI.Text, txtPhone.Text, txtEmail.Text, txtContactName.Text), connection);
            //        string query = string.Format("Insert into dbo.Agency(agencyName, programName,CFDA,agencyContact,agencyEmail,agencyContactName) " +
            //        "values('{0}','{1}',{2},{3},'{4}','{5}')", txtApplicant.Text, txtDepartment.Text, txtCFDI.Text, txtPhone.Text, txtEmail.Text, txtContactName.Text);
            //        using (SqlCommand cmd = new SqlCommand(query, connection))
            //        {
            //            int rows = cmd.ExecuteNonQuery();
            //        }
                    
            //        MessageBox.Show("Agency added successfully !!", "Agency", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
