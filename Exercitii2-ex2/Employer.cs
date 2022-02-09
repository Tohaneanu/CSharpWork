// See https://aka.ms/new-console-template for more information

using System;

namespace Exercitii2_ex2
{
    public class Employer
    {
        public string Name;
        public DateTime HiringDateTime;
        public int WorkDays;
        public int DayHours;

        public Employer(string name, DateTime hiringDateTime, int dayHours)
        {
            this.DayHours = dayHours;
            this.WorkDays = 0;
            Name = name;
            HiringDateTime = hiringDateTime;
        }

        public int WorkDays1
        {
            get => WorkDays;
            set => WorkDays = value;
        }

        public override string ToString()
        {
            return "nume " + this.Name + " zile mucite " + this.WorkDays + " ore pe zi muncite: " + this.DayHours;
        }

        public bool Equals(Employer obj)
        {
            return this.Name == obj.Name && this.HiringDateTime == obj.HiringDateTime;
        }
    }
}