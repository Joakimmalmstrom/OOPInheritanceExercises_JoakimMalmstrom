using System;
using System.Linq;
using System.Text;

namespace OOPInheritanceExercises_JoakimMalmstrom
{
    internal class Human
    {
        private string fName;
        private string lName;

        public string FName
        {
            get { return fName; }
            set 
            {
                var firstLetter = value.Split(' ').First().ToCharArray();

                if (!char.IsUpper(firstLetter[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: fName");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: fName");

                }
                fName = value; 
            }
        }
        

        public string LName
        {
            get { return lName; }
            set
            {
                var firstLetter = value.Split(' ').First().ToCharArray();

                if (!char.IsUpper(firstLetter[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lName");

                }
                lName = value;
            }
        }

        public Human(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(
                $"First Name: {FName} \n" +
                $"Last Name: {LName} \n");

            return stringBuilder.ToString();
        }
    }
}