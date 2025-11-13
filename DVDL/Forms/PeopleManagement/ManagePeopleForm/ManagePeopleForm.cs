using System;
using System.Data;
using System.Linq;
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
            InitializeCBFilterBy();
            RefreshTable();
        }

        private void RefreshTable()
        {
            DGVManagePeople.DataSource = PeopleBusinessLayer.People.GetAllPeople();
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
                if (!PeopleBusinessLayer.People.DeletePerson(PersonID))
                {
                    MessageBox.Show("Failed to delete, The user has data linked to him ! ");
                }

                RefreshTable();
            }
            else
                return;

        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBFilterBy.SelectedItem.ToString().ToLower())
            {
                case "none":
                    RTBFilterBy.Visible = false;
                    RTBFilterBy.Clear();
                    break;
                case "personid":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "firstname":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "secondname":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "thirdname":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "lastname":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "address":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "dateofbirth":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "nationalno":
                    RTBFilterBy.Visible = true;
                    RTBFilterBy.Clear();
                    break;
                case "phone":
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
            }
        }

        private void RTBFilterBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (CBFilterBy.SelectedItem == null || CBFilterBy.SelectedItem.ToString() == "None")
            {
                RefreshTable();
                return;
            }

            string filterText = RTBFilterBy.Text.Trim();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                RefreshTable();
                return;
            }

            try
            {
                DataTable allPeople = People.GetAllPeople();
                DataRow[] filteredRows = null;
                string filterExpression = "";

                switch (CBFilterBy.SelectedItem.ToString().ToLower())
                {
                    case "personid":
                        if (filterText.All(char.IsDigit))
                        {
                            filterExpression = $"Convert(PersonID, 'System.String') LIKE '%{filterText}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;

                    case "firstname":
                        filterExpression = $"FirstName LIKE '%{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "secondname":
                        filterExpression = $"SecondName LIKE '%{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "thirdname":
                        filterExpression = $"ThirdName LIKE '%{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "lastname":
                        filterExpression = $"LastName LIKE '%{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "address":
                        filterExpression = $"Address LIKE '%{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "nationalno":
                        if (filterText.All(char.IsDigit))
                        {
                            filterExpression = $"NationalNo LIKE '%{filterText}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;

                    case "phone":
                        if (filterText.All(char.IsDigit))
                        {
                            filterExpression = $"Phone LIKE '%{filterText}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;
                }

                // Update DataGridView
                if (filteredRows != null && filteredRows.Length > 0)
                {
                    DGVManagePeople.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    DGVManagePeople.DataSource = null;
                }

                lblRecordCount.Text = "# Record: " + (filteredRows?.Length ?? 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshTable();
            }
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


