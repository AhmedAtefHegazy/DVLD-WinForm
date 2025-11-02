using System;
using System.Windows.Forms;
using DVDL.Forms.PeopleManagement;
namespace DVDL
{
    public partial class FrmManagePeople : Form
    {
        public FrmManagePeople()
        {
            InitializeComponent();
            DGVManagePeople.DataSource = PeopleBusinessLayer.People.GetAllPeople();
            RefreshTable();
        }

        private void RefreshTable()
        {
            DGVManagePeople.Refresh();
            lblRecordCount.Text = "# Record: " + DGVManagePeople.RowCount.ToString();
        }

        private void btnCloseManagePeopleForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DGVManagePeople.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int PersonID = (int)DGVManagePeople.SelectedRows[0].Cells["PersonID"].Value;


            Form frmShowPerson = new FrmShowPersonForm(PersonID);
            frmShowPerson.ShowDialog();
        }



        private void DGVManagePeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
