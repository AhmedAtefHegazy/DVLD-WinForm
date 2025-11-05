using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        public FrmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent();
            LBLFormStatus.Text = (PersonID != -1) ? "Update Person" : "Add New Person";
            lblPersonId.Text = (PersonID != -1) ? PersonID.ToString() : "N/A";
        }
    }
}
