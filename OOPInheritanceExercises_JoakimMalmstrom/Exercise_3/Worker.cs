using System;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace OOPInheritanceExercises_JoakimMalmstrom
{
    internal class Worker : Human
    {
        private int weekSalary;
        private int workHours;

        public int WeekSalary
        {
            get { return weekSalary; }
            set 
            {
                if (value < 11)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value; 
            }
        }

        public int Workhours
        {
            get { return workHours; }
            set
            {
                if (value < 1 && value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHours = value;
            }
        }

        public double HourSalary
        {
            get 
            {
                return weekSalary / (workHours * 5);
            }
        }


        public Worker(string fName, string lName, int weekSalary, int workHours) : base(fName, lName)
        {
            WeekSalary = weekSalary;
            Workhours = workHours;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(
                $"Week Salary: {WeekSalary:f2} \n" +
                $"Hours Per Day: {Workhours:f2} \n" +
                $"Salary Per Hour: {HourSalary:f2} ");

            return base.ToString() + stringBuilder.ToString();
        }
    }
}