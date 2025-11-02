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
        }

        private void btnCloseManagePeopleForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
