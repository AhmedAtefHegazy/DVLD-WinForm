using System;
using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement.UserControls
{
    public partial class ctrPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
            CbFindBy.SelectedIndex = 0;
        }

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if (Handler != null)
                Handler(PersonID);
        }

        private void BtnAddNewPerson_Click(object sender, System.EventArgs e)
        {
            FrmAdd_EditPersonInfo FrmAddNewPerson = new FrmAdd_EditPersonInfo(-1);
            FrmAddNewPerson.ShowDialog();
            if (FrmAddNewPerson.PersonID != -1)
            {
                ctrPersonCardInformation1.FillPersonInfo(FrmAddNewPerson.PersonID);
            }
        }

        private void BtnSearchForPerson_Click(object sender, System.EventArgs e)
        {
            if (TbFindBy.Text != string.Empty)
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

                if (OnPersonSelected != null)
                    PersonSelected(ctrPersonCardInformation1.PersonID);
            }

            else
            {
                if (string.IsNullOrEmpty(TbFindBy.Text.Trim()))
                {
                    errorProvider1.SetError(TbFindBy, "This field is required !");
                }

                else
                {
                    errorProvider1.SetError(TbFindBy, null);
                }

            }
        }

        private void CbFindBy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TbFindBy.Clear();
        }

        private void TbFindBy_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbFindBy.Text.Trim()))
            {
                errorProvider1.SetError(TbFindBy, "This field is required !");
            }

            else
            {
                errorProvider1.SetError(TbFindBy, null);
            }

        }

        private void TbFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the user pressed enter then preform search 
            if (e.KeyChar == (char)13)
            {
                BtnSearchForPerson.PerformClick();
            }

            if (CbFindBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

        }
    }
}
