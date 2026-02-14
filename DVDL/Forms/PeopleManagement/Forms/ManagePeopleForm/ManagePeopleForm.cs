using System;
using System.Data;
using System.IO;
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
            switch (CBFilterBy.SelectedItem.ToString().ToLower())
            {
                case "none":
                    RTBFilterBy.Visible = false;
                    RTBFilterBy.Clear();
                    break;
                case "personid":
                case "firstname":
                case "secondname":
                case "thirdname":
                case "lastname":
                case "address":
                case "dateofbirth":
                case "nationalno":
                case "phone":
                case "email":
                case "gender":
                case "nationalitycountryid":
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
                case "nationalitycountryid":
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
                            filterExpression = $"Convert(PersonID, 'System.String') = '{filterText}'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;

                    case "firstname":
                        filterExpression = $"FirstName LIKE '{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "secondname":
                        filterExpression = $"SecondName LIKE '{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "thirdname":
                        filterExpression = $"ThirdName LIKE '{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "lastname":
                        filterExpression = $"LastName LIKE '{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "address":
                        filterExpression = $"Address LIKE '{filterText}%'";
                        filteredRows = allPeople.Select(filterExpression);
                        break;

                    case "nationalno":
                        if (filterText.All(char.IsDigit))
                        {
                            filterExpression = $"NationalNo LIKE '{filterText}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;

                    case "phone":
                        if (filterText.All(char.IsDigit))
                        {
                            filterExpression = $"Phone LIKE '{filterText}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;
                    case "email":
                        if (allPeople.Columns.Contains("Email"))
                        {
                            filterExpression = $"Email LIKE '{(filterText)}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;

                    case "gender":
                        if (allPeople.Columns.Contains("Gender"))
                        {
                            // support single-char codes (M/F/U) or full words ('male','female')
                            var t = filterText.Trim().ToLowerInvariant();
                            if (t.Length == 1)
                            {
                                filterExpression = $"Convert(Gender, 'System.String') = '{(t.ToUpperInvariant())}'";
                            }
                            else if (t == "male" || t.StartsWith("m"))
                            {
                                filterExpression = $"Convert(Gender, 'System.String') = 'M'";
                            }
                            else if (t == "female" || t.StartsWith("f"))
                            {
                                filterExpression = $"Convert(Gender, 'System.String') = 'F'";
                            }
                            else
                            {
                                filterExpression = $"Convert(Gender, 'System.String') LIKE '{(filterText)}%'";
                            }
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        break;

                    case "nationalitycountryid":
                        // grid might include either the ID column or a display column (e.g. NationalityCountry)
                        if (allPeople.Columns.Contains("NationalityCountry"))
                        {
                            filterExpression = $"NationalityCountry LIKE '{(filterText)}%'";
                            filteredRows = allPeople.Select(filterExpression);
                        }
                        else if (allPeople.Columns.Contains("NationalityCountryID"))
                        {
                            if (filterText.All(char.IsDigit))
                            {
                                filterExpression = $"Convert(NationalityCountryID, 'System.String') = '{(filterText)}'";
                                filteredRows = allPeople.Select(filterExpression);
                            }
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

        private void DGVManagePeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new FrmShowPersonForm((int)DGVManagePeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}


