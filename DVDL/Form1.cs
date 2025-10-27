using System.Windows.Forms;

namespace DVDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SMI_pepole_Click(object sender, System.EventArgs e)
        {
            Form PeopleManage = new FrmManagePeople();
            PeopleManage.Show();
        }
    }
}
