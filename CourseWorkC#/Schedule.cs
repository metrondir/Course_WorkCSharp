using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
    public class Schedule : IEnumerable
    {
        private List<Train_Info> trains;
        private int count = 0;

        public Schedule()
        {
            trains = new List<Train_Info>();
        }
        ~Schedule() { }

        public Schedule(int ncount)
        {
            trains = new List<Train_Info>();
            count = ncount;
        }
        public IEnumerator GetEnumerator()
        {
            return new MyIterator(trains);
        }

        public List<Train_Info> GetTrains()
        {
            return trains;
        }
        public void AddTrain(string destination, int hour, int minutes, int seconds, int platform)
        {
            trains.Add(new Train_Info(destination, hour, minutes, seconds, platform));
        }
        public string FindNearestTrain(string destination, int hours, int minutes, int seconds)
        {
            string totalTime = " ";

            foreach (Train_Info train in trains)
            {
                if (train.Destination == destination)
                {
                    if (train.Hours < hours)
                    {
                        hours = train.Hours;
                        minutes = train.Minutes;
                        seconds = train.Seconds;
                    }
                    else if (train.Hours == hours && train.Minutes < minutes)
                    {
                        minutes = train.Minutes;
                        seconds = train.Seconds;
                    }
                    else if (train.Hours == hours && train.Minutes == minutes && train.Seconds < seconds)
                    {
                        seconds = train.Seconds;
                    }
                }
            }
            totalTime = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
            return totalTime;
        }
    }
}
