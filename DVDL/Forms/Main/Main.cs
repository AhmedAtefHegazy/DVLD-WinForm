using System.Windows.Forms;

namespace DVDL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SMI_pepole_Click(object sender, System.EventArgs e)
        {
            Form PeopleManage = new FrmManagePeople();
            PeopleManage.ShowDialog();
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected(int PersonID)
        {
            MessageBox.Show("PersonID =" + PersonID);
        }

    }
}
