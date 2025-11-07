using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        public FrmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent(PersonID);
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTBNameFirst.Text))
            {
                EP.SetError(RTBNameFirst, "enter first name");
            }
        }

    }
}
