using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DVDL.Forms.PeopleManagement;
using PeopleBusinessLayer;
namespace DVDL
{
    public partial class FrmManagePeople : Form
    {

        private static DataTable _dtAllPeople = PeopleBusinessLayer.People.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.
                ToTable(false, "PersonID", "NationalNo",
                              "FirstName", "SecondName", "ThirdName", "LastName",
                              "GenderCaption", "DateOfBirth", "CountryName",
                              "Phone", "Email");

        public FrmManagePeople()
        {
            InitializeComponent();
            RefreshTable();
            InitializeCBFilterBy();
        }

        private void RefreshTable()
        {
            _dtPeople = PeopleBusinessLayer.People.GetAllPeople().DefaultView.
        ToTable(false, "PersonID", "NationalNo",
                      "FirstName", "SecondName", "ThirdName", "LastName",
                      "GenderCaption", "DateOfBirth", "CountryName",
                      "Phone", "Email");

            if (DGVManagePeople.Rows.Count > 0)
            {

                DGVManagePeople.Columns[0].HeaderText = "Person ID";
                DGVManagePeople.Columns[0].Width = 80;

                DGVManagePeople.Columns[1].HeaderText = "National No.";
                DGVManagePeople.Columns[1].Width = 120;


                DGVManagePeople.Columns[2].HeaderText = "First Name";
                DGVManagePeople.Columns[2].Width = 120;

                DGVManagePeople.Columns[3].HeaderText = "Second Name";
                DGVManagePeople.Columns[3].Width = 140;


                DGVManagePeople.Columns[4].HeaderText = "Third Name";
                DGVManagePeople.Columns[4].Width = 120;

                DGVManagePeople.Columns[5].HeaderText = "Last Name";
                DGVManagePeople.Columns[5].Width = 120;

                DGVManagePeople.Columns[6].HeaderText = "Gender";
                DGVManagePeople.Columns[6].Width = 80;

                DGVManagePeople.Columns[7].HeaderText = "Date Of Birth";
                DGVManagePeople.Columns[7].Width = 140;

                DGVManagePeople.Columns[8].HeaderText = "Nationality";
                DGVManagePeople.Columns[8].Width = 80;


                DGVManagePeople.Columns[9].HeaderText = "Phone";
                DGVManagePeople.Columns[9].Width = 120;


                DGVManagePeople.Columns[10].HeaderText = "Email";
                DGVManagePeople.Columns[10].Width = 160;
            }

            DGVManagePeople.DataSource = _dtPeople;

            lblRecordCount.Text = "# Record: " + DGVManagePeople.RowCount.ToString();

        }

        private void InitializeCBFilterBy()
        {
            CBFilterBy.Items.Add("None");

            foreach (DataGridViewColumn Column in DGVManagePeople.Columns)
            {
                if (Column.Name != "DateOfBirth" && Column.Name != "ImagePath" && Column.Name != "")
                    CBFilterBy.Items.Add(Column.Name);
            }

            CBFilterBy.SelectedItem = "None";
            RTBFilterBy.Visible = false;
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
                People Person = People.Find(PersonID);
                string OldImagePath = Person.ImagePath;

                //Perform Delele and refresh
                if (People.DeletePerson((int)DGVManagePeople.CurrentRow.Cells[0].Value))
                {
                    if (OldImagePath != string.Empty)
                        File.Delete(OldImagePath);
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFilterBy.SelectedItem == null)
                return;

            string selected = CBFilterBy.SelectedItem.ToString().ToLower();

            switch (selected)
            {
                case "none":
                    RTBFilterBy.Visible = false;
                    RTBFilterBy.Clear();
                    break;

                case "personid":
                case "nationalno":
                case "firstname":
                case "secondname":
                case "thirdname":
                case "lastname":
                case "dateofbirth":
                case "phone":
                case "email":
                case "gender":
                case "gendercaption":
                case "countryname":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
            }
        }

        private void RTBFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (CBFilterBy.SelectedItem.ToString().ToLower())
            {
                case "personid":
                case "phone":
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }
                    break;
                case "gender":
                    if (RTBFilterBy.Text.Length >= 1)
                    {
                        e.Handled = true;
                        return;
                    }
                    break;
            }
        }

        private void RTBFilterBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string FilterColumn = CBFilterBy.Text;
            string FilterValue = RTBFilterBy.Text.Trim();

            // Reset filters if "None" is selected or text is empty
            if (FilterColumn == "None" || string.IsNullOrEmpty(FilterValue))
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordCount.Text = "# Record: " + DGVManagePeople.RowCount.ToString();
                return;
            }

            // Handle "PersonID" separately because it is a Number, not a String
            if (FilterColumn == "PersonID")
            {
                // Use direct equality for numbers (no LIKE)
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            }
            else
            {
                // Use LIKE for strings
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            }

            lblRecordCount.Text = "# Record: " + DGVManagePeople.RowCount.ToString();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will coming soon !", "Not Ready yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will coming soon !", "Not Ready yet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DGVManagePeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new FrmShowPersonForm((int)DGVManagePeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}


