using System;
using System.ComponentModel;

namespace OOPInheritanceExercises_JoakimMalmstrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();

            Console.ReadLine();

        }

        // EXERCISE 1
        private static void ExerciseOne()
        {
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Person person = new Person(name, age);
                Child child = new Child(name, age);

                Console.WriteLine("\n" + person);
                Console.WriteLine(child);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // EXERCISE 2
        private static void ExerciseTwo()
        {
            try
            {
                Book book = new GoldenEditBook("Joakim Malmström", "Kronans Palats", 25);

                Console.WriteLine(book.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // EXERCISE 3
        private static void ExerciseThree()
        {
            try
            {
                Human human = new Worker("Joakim", "Malmström", 1000, 8);

                Console.WriteLine(human);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
