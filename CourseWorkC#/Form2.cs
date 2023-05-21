using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkC_
{
    public partial class Form2 : Form
    {
        Schedule sch;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Schedule schedule)
        {
            sch = schedule;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
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
                    string nearestTrain = sch.Find(destination, 23, 59, 59);
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
