using System;


namespace CourseWorkC_
{
    public class Time
    {

        protected int hours;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0 && value < 24)
                    hours = value;
                else
                    throw new MyException("Invalid hours value");
            }
        }
        protected int minutes;
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else
                    throw new MyException("Invalid minutes value");
            }
        }
        protected int seconds;
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value < 60)
                    seconds = value;
                else
                    throw new MyException("Invalid seconds value");
            }
        }
        ~Time()
        {

        }
        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
       public Time(int hours,int minutes ,int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds; 
        }
        public Time(Time t)
        {
            Hours = t.hours;
            Minutes = t.minutes;
            Seconds = t.seconds;
        }
        public static Time operator +(Time time1, Time time2)
        {
            int totalSeconds = time1.hours * 3600 + time1.minutes * 60 + time1.seconds;
            int otherTotalSeconds = time2.hours * 3600 + time2.minutes * 60 + time2.seconds;

            int sum = totalSeconds + otherTotalSeconds;

            int h = sum / 3600 % 24;
            int m = sum / 60 % 60;
            int s = sum % 60;

            return new Time(h, m, s);
        }

        public static Time operator -(Time time1, Time time2)
        {
            int totalSeconds = time1.hours * 3600 + time1.minutes * 60 + time1.seconds;
            int otherTotalSeconds = time2.hours * 3600 + time2.minutes * 60 + time2.seconds;

            int diff = totalSeconds - otherTotalSeconds;
            if (diff < 0)
                diff += 24 * 3600;

            int h = diff / 3600 % 24;
            int m = diff / 60 % 60;
            int s = diff % 60;

            return new Time(h, m, s);
        }
        public override string ToString()
        {
            return $" {hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}";
        }

    }
}

