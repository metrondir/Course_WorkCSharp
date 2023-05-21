using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
    public class Train_Info : Time
    {
        private string destination;
        private int platform;

        public Train_Info()
        {
            destination = string.Empty;
            platform = 0;
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Train_Info(Train_Info trn)
        {
            this.Hours = trn.Hours;
            this.Minutes = trn.Minutes;
            this.Seconds = trn.Seconds;
            this.Destination = trn.destination;
            this.Platform = trn.platform;
        }
        public Train_Info(string dest, int h, int m, int s, int plat) : base(h, m, s)
        {
           destination = dest;
           Platform = plat;
        }
        public Train_Info(string destination, Train_Info t) : base(t)
        {
            this.destination = destination;
            Platform = t.platform;
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int Platform
        {
            get { return platform; }
            set
            {
                if (value > 0)
                    platform = value;
                else
                    throw new MyException("Invalid seconds value");
            }
            }
        public override string ToString()
        {
            return $"Train to {destination} departs at {base.ToString()} from platform {platform}";
        }
    }
}
