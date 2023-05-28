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
        private List<Train_Info> Trains;
        private int Count = 0;

        public Schedule()
        {
            Trains = new List<Train_Info>();
        }
        ~Schedule() { }

        public Schedule(int count)
        {
            Trains = new List<Train_Info>();
            Count = count;
        }
        public IEnumerator GetEnumerator()
        {
            return new MyIterator(Trains);
        }

        public List<Train_Info> GetTrains()
        {
            return Trains;
        }
        public void AddTrain(string destination, int hour, int minutes, int seconds, int platform)
        {
            Trains.Add(new Train_Info(destination, hour, minutes, seconds, platform));
        }
        public string Find(string destination, int hours, int minutes, int seconds)
        {
            string totalTime = "00:00:00";

            foreach (Train_Info train in Trains)
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
