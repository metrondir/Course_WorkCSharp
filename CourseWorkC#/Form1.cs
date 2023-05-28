using System;
using System.Linq;
using System.Windows.Forms;


namespace CourseWorkC_
{
    public partial class Form1 : Form
    {
        Schedule sch;
        int selectionIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            sch = new Schedule();
        }

        private void buttonListClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sch.GetTrains().Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
                selectionIndex = listView1.SelectedIndices[0];
        }

        private void buttonTimeInfo_Click(object sender, EventArgs e)
        {
            Time[] refArray = new Time[1];
            if (listView1.SelectedIndices.Count > 0)
            {
                selectionIndex = listView1.SelectedIndices[0];
                refArray[0] = new Time(sch.GetTrains().ElementAt(selectionIndex));
                MessageBox.Show(refArray[0].ToString() + "\n", "Info About Time");
            }
            else
            {
                MessageBox.Show("No item selected.", "Info About Time");
            }
        }
        private void buttonDepartureTime_Click(object sender, EventArgs e)
        {
            Time[] refArray = new Time[1];
            if (listView1.SelectedIndices.Count > 0)
            {
                selectionIndex = listView1.SelectedIndices[0];
                refArray[0] = new Train_Info(sch.GetTrains().ElementAt(selectionIndex));
                MessageBox.Show(refArray[0].ToString() + "\n", "INFO ABOUT TRAIN");
            }
            else
            {
                MessageBox.Show("No item selected.", "Info About Time");
            }
        }

        private void buttonNearestTrain_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(sch);
            form2.ShowDialog();
        }

        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Destination.Text))
            {
                MessageBox.Show("Fill in the field Destination ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(Hours.Text))
            {
                MessageBox.Show("Fill in the field Hours ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(Minutes.Text))
            {
                MessageBox.Show("Fill in the field Minutes ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(Seconds.Text))
            {
                MessageBox.Show("Fill in the field Seconds ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(Platform.Text))
            {
                MessageBox.Show("Fill in the field Platform ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (int.TryParse(Destination.Text, out _))
                    {
                        throw new MyException("Destination must be a string.");
                    }
                    if (!int.TryParse(Platform.Text,out _))
                    {
                        throw new MyException("Platform fields must contain numeric values.");
                    }
                    if (!int.TryParse(Hours.Text, out _) || !int.TryParse(Minutes.Text, out _) || !int.TryParse(Seconds.Text, out _))
                    {
                        throw new MyException("Time field must contain numeric values.");
                    }
                    sch.AddTrain(Destination.Text, int.Parse(Hours.Text), int.Parse(Minutes.Text), int.Parse(Seconds.Text), int.Parse(Platform.Text));
                    listView1.Items.Clear();
                    string[] str = new string[3];
                    foreach (Train_Info train in sch.GetTrains())
                    {
                        str[0] = train.Destination;
                        str[1] = train.Hours.ToString("D2") + ":" + train.Minutes.ToString("D2") + ":" + train.Seconds.ToString("D2");
                        str[2] = train.Platform.ToString();
                        listView1.Items.Add(new ListViewItem(str));
                    }
                    Destination.Clear();
                    Hours.Clear();
                    Minutes.Clear();
                    Seconds.Clear();
                    Platform.Clear();
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.ShowException(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
