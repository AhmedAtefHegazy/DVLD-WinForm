using System;
using System.Windows.Forms;
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
    }
}
