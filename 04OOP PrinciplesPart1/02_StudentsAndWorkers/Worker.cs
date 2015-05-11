using System;

namespace _02_StudentsAndWorkers
{
    class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal result = 0M;
            result = WeekSalary / WorkHoursPerDay * 5;
            return result;
        }
    }
}
