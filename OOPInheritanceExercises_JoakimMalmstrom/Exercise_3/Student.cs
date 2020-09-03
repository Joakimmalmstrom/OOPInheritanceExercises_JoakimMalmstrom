using System;
using System.Text;

namespace OOPInheritanceExercises_JoakimMalmstrom
{
    internal class Student : Human
    {
        private string facultyNr;

        public string FacultyNr
        {
            get { return facultyNr; }
            set 
            {
                if (value.Length > 4 && value.Length < 11)
                {
                    facultyNr = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }

        public Student(string fName, string lName, string facultyNr) : base(fName, lName)
        {
            FacultyNr = facultyNr;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Faculty Number: {FacultyNr} ");

            return base.ToString() + stringBuilder.ToString();
        }
    }
}