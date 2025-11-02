using System;
using System.IO;
using System.Windows.Forms;
using DVDL.Forms.PeopleManagement;
using PeopleBusinessLayer;
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

            DataGridViewRow selectedRow = DGVManagePeople.SelectedRows[0];

            People Person = new People();

            Person.PersonID = selectedRow.Cells["PersonID"].Value == DBNull.Value ? 0 : Convert.ToInt32(selectedRow.Cells["PersonID"].Value);
            Person.FirstName = selectedRow.Cells["FirstName"].Value?.ToString() ?? "";
            Person.SecondName = selectedRow.Cells["SecondName"].Value?.ToString() ?? "";
            Person.ThirdName = selectedRow.Cells["ThirdName"].Value?.ToString() ?? "";
            Person.FourthName = selectedRow.Cells["FourthName"].Value?.ToString() ?? "";
            Person.Address = selectedRow.Cells["Address"].Value?.ToString() ?? "";

            Person.DateOfBirth = selectedRow.Cells["DateOfBirth"].Value == DBNull.Value
                ? DateTime.MinValue
                : Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);

            Person.NationalNo = selectedRow.Cells["NationalNo"].Value?.ToString() ?? "";
            Person.PhoneNumber = selectedRow.Cells["PhoneNumber"].Value?.ToString() ?? "";
            Person.Email = selectedRow.Cells["Email"].Value?.ToString() ?? "";

            Person.Gender = selectedRow.Cells["Gender"].Value == DBNull.Value
                ? 'U'
                : Convert.ToChar(selectedRow.Cells["Gender"].Value);

            if (File.Exists(selectedRow.Cells["ImagePath"].Value.ToString()))
                Person.ImagePath = selectedRow.Cells["ImagePath"].Value?.ToString() ?? "";

            Person.CountryID = selectedRow.Cells["CountryID"].Value == DBNull.Value
                ? (short)0
                : Convert.ToInt16(selectedRow.Cells["CountryID"].Value);



            Form frmShowPerson = new FrmShowPersonForm(Person);
            frmShowPerson.ShowDialog();
        }



        private void DGVManagePeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
