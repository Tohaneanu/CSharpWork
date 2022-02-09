// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Exercitii2_ex2
{
    public class Company
    {
        public List<Employer> Employers;
        public List<DateTime> FreeDays;

        public Company()
        {
            Employers = new List<Employer>();
            FreeDays = new List<DateTime>();
        }

        public void AddEmployer(Employer e)
        {
            Employers.Add(e);
        }

        public void AddFreeDays(DateTime dateTime)
        {
            FreeDays.Add(dateTime);
        }

        public List<DateTime> FreeDays1
        {
            get => FreeDays;
            set => FreeDays = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void CalculateWorkDays()
        {
            foreach (var emp in Employers)
            {
                int days = 0;
                for (DateTime date = emp.HiringDateTime; date < DateTime.Now; date = date.AddDays(1))
                {
                    if (date.DayOfWeek != DayOfWeek.Saturday &&
                        date.DayOfWeek != DayOfWeek.Sunday && !FreeDays.Contains(date))
                    {
                        days++;
                    }
                }

                emp.WorkDays = days;
            }
        }

        public int CalculateWorkedHours(Employer employer)
        {
            foreach (var emp in Employers)
            {
                if (emp.Equals(employer) && employer.WorkDays > 0)
                {
                    return emp.DayHours * employer.WorkDays;
                }
            }

            return 0;
        }

        public void printEmp()
        {
            foreach (var e in Employers)
            {
                Console.WriteLine(e);
            }
        }
    }
}