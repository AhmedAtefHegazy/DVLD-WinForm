using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmShowPersonForm : Form
    {
        public FrmShowPersonForm(int Person)
        {
            InitializeComponent();
            FillPersoninfo(Person);
        }

        private void FillPersoninfo(int PersonID)
        {
            cardPersonInformation1.FillPersonInfo(PersonID);
        }

        private void btnCloseShowPersonForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
