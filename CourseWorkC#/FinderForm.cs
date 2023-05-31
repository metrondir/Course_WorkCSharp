using System;
using System.Windows.Forms;

namespace CourseWorkC_
{
    public partial class FinderForm : Form
    {
        Schedule sch;
        public FinderForm()
        {
            InitializeComponent();
        }

        public FinderForm(Schedule schedule)
        {
            sch = schedule;
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string destination = Destination.Text;
            if (!string.IsNullOrEmpty(destination))
            {
                bool destinationExists = false;
                foreach (Train_Info train in sch.GetTrains())
                {
                    if (train.Destination.Equals(destination))
                    {
                        destinationExists = true;
                        break;
                    }
                }

                if (destinationExists)
                {
                    string nearestTrain = sch.FindNearestTrain(destination, 23, 59, 59);
                    string str = "Nearest train to " + destination + " on " + nearestTrain;
                    Close();
                    MessageBox.Show(str, "Nearest train");
                }
                else
                {
                    MessageBox.Show("The specified destination does not exist in the train list.", "Invalid Destination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
