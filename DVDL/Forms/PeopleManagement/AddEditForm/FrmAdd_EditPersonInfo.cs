using System.Windows.Forms;
using DVDL.Properties;

namespace DVDL.Forms.PeopleManagement
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        public FrmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent();
            LBLFormStatus.Text = (PersonID != -1) ? "Update Person" : "Add New Person";
            lblPersonId.Text = (PersonID != -1) ? PersonID.ToString() : "N/A";
            if (RBFemale.Checked == true)
                PBPersonImage.Image = Resources.Female_512;
            else
                PBPersonImage.Image = Resources.Male_512;
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
