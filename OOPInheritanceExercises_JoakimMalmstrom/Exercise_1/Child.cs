using System;

namespace OOPInheritanceExercises_JoakimMalmstrom
{
    internal class Child : Person
    {
        public override int Age 
        { 
            get => base.Age;
            
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child cannot be older than 15");
                }
                base.Age = value;
            }
        }

        public Child(string name, int age) : base(name, age)
        {

        }
    }
}