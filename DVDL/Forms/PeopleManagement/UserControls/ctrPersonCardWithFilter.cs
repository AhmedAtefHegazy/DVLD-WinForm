using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement.UserControls
{
    public partial class ctrPersonCardWithFilter : UserControl
    {
        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
            CbFindBy.SelectedIndex = 0;
        }

        private void BtnAddNewPerson_Click(object sender, System.EventArgs e)
        {
            Form FrmAddNewPerson = new FrmAdd_EditPersonInfo(-1);
            FrmAddNewPerson.ShowDialog();
        }

        private void BtnSearchForPerson_Click(object sender, System.EventArgs e)
        {
            switch (CbFindBy.SelectedIndex)
            {
                //By ID
                case 0:
                    ctrPersonCardInformation1.FillPersonInfo(TbFindBy.Text);
                    break;

                //By National No.
                case 1:
                    if (int.TryParse(TbFindBy.Text, out int PersonID))
                    {
                        ctrPersonCardInformation1.FillPersonInfo(PersonID);
                    }
                    break;
                default:
                    break;
            }

        }

        private void TbFindBy_TextChanged(object sender, System.EventArgs e)
        {
            if (!int.TryParse(TbFindBy.Text, out int PersonID) && CbFindBy.SelectedIndex == 1)
            {
                TbFindBy.Clear();
            }
        }

        private void CbFindBy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TbFindBy.Clear();
        }
    }
}
