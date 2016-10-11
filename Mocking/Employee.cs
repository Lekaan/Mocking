using System;

namespace Mocking
{
    public class Employee
    {
        public int Id { get; internal set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public int Wage { get; internal set; }

        internal double CalculateWeeklySalary(int hours, int wage)
        {
            return hours*wage;
        }
        internal double CalculateWeeklySalaryAverage(int hours, int wage, int Count)
        {
            return (hours * wage) / Count;
        }
    }
}