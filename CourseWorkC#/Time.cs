﻿using System;


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
        public virtual string GetTime()
        {
            return $" {hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}";
        }

    }
}

