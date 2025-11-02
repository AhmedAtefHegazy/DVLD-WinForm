using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmShowPersonForm : Form
    {
        public FrmShowPersonForm(People Person)
        {
            InitializeComponent();
            FillPersoninfo(Person);
        }

        private void FillPersoninfo(People Person)
        {
            cardPersonInformation1.FillPersonInfo(Person);
        }

        private void btnCloseShowPersonForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
