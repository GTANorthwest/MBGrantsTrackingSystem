using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grants_Tracking_Application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newProjectGrantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProject addproject = new AddProject();
            addproject.ShowDialog();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProject editproject = new EditProject();
            editproject.ShowDialog();
        }

        private void newPIApplicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPI addPI = new AddPI();
            addPI.ShowDialog();
        }

        private void newAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAgency addAgency = new AddAgency();
            addAgency.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\S519376\Desktop\Help File\Grants Tracking Application.chm");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importExportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Import Grant Details";
            openFileDialog1.Filter = "Import (*.xlsx)|*.xlsx";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
