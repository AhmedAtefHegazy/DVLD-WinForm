using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmShowPersonForm : Form
    {
        public FrmShowPersonForm(People person)
        {
            InitializeComponent();
        }

        private void FillPersoninfo()
        {

        }

        private void btnCloseShowPersonForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
