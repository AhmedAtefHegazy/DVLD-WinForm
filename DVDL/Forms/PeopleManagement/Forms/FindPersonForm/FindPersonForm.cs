using System;
using System.Windows.Forms;

namespace DVDL.Forms.PeopleManagement.Forms.FindPersonForm
{
    public partial class FindPersonForm : Form
    {
        private int PersonID = -1;

        //Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonIdD);

        //Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public FindPersonForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Trigger the event to send databack to the caller form
            DataBack?.Invoke(this, PersonID);
            this.Close();
        }

        //uses OnPersonSelected Event to get the Person ID from the user control
        private void ctrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            this.PersonID = obj;
        }
    }
}
