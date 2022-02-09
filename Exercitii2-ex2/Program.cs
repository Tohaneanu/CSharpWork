// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Exercitii2_ex2
{
    public class main
    {
        public static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time);
            Console.WriteLine(time.DayOfWeek.ToString());

            Employer employer = new Employer("Emp1", new DateTime(2019, 10, 26), 8);
            Company company = new Company();
            company.AddEmployer(employer);
            List<DateTime> free = new List<DateTime>()
            {
                new DateTime(2021, 12, 25),
                new DateTime(2021, 12, 26),
                new DateTime(2022, 1, 1),
                new DateTime(2022, 1, 26)
            };
            company.FreeDays = free;
            Console.WriteLine($"Ore lucrate de angajatul Empl1 {company.CalculateWorkedHours(employer)}");
            company.CalculateWorkDays();
            company.printEmp();
            Console.WriteLine($"Ore lucrate de angajatul Empl1 {company.CalculateWorkedHours(employer)}");
        }
    }
}