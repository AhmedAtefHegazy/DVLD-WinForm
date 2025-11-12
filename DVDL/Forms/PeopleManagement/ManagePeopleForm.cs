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
            RefreshTable();
        }

        private void RefreshTable()
        {
            DGVManagePeople.DataSource = PeopleBusinessLayer.People.GetAllPeople();
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



        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form FrmAddPerson = new FrmAdd_EditPersonInfo(-1);
            FrmAddPerson.ShowDialog();
            RefreshTable();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmAddPerson = new FrmAdd_EditPersonInfo(-1);
            FrmAddPerson.ShowDialog();
            RefreshTable();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVManagePeople.SelectedRows[0].Cells["PersonID"].Value;

            Form FrmEditPerson = new FrmAdd_EditPersonInfo(PersonID);
            FrmEditPerson.ShowDialog();
            RefreshTable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVManagePeople.SelectedRows[0].Cells["PersonID"].Value;



            if (MessageBox.Show($"Sure to delete {DGVManagePeople.SelectedRows[0].Cells["FirstName"].Value.ToString()}", "Delete Person", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (!PeopleBusinessLayer.People.DeletePerson(PersonID))
                {
                    MessageBox.Show("Failed to delete, The user has data linked to him ! ");
                }

                RefreshTable();
            }
            else
                return;

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will coming soon !", "Not Ready yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will coming soon !", "Not Ready yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
