using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;

namespace OOPInheritanceExercises_JoakimMalmstrom
{
    internal class Book
    {
        private string author;
        private string title;
        private decimal price;

        public string Author
        {
            get { return author; }
            set
            {
                var firstLetterFirstName = value.Split(' ').First().ToCharArray();
                var firstLetterLastName = value.Split(' ').Last().ToCharArray();

                if (char.IsDigit(firstLetterFirstName[0]) || char.IsDigit(firstLetterLastName[0]))
                {
                    throw new System.Exception("Author not valid!");
                }
                author = value;
            }
        }

        public string Title
        {
            get { return title; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new System.Exception("Title not valid!");
                }
                title = value; 
            }
        }

        public virtual decimal Price
        {
            get  { return price; }
            set 
            {
                if (value <= 0)
                {
                    throw new System.Exception("Price not valid!");
                }
                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();

            resultBuilder.Append(
                $"Type: {GetType().Name} \n" +
                $"Author: {Author} \n" +
                $"Title: {Title} \n" +
                $"Price: {Price:f2} \n");

            return resultBuilder.ToString().TrimEnd();
        }
    }
}