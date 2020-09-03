namespace OOPInheritanceExercises_JoakimMalmstrom
{
    internal class GoldenEditBook : Book
    {

        public override decimal Price 
        {
            get { return base.Price * (decimal)1.3; }
        }
        public GoldenEditBook(string author, string title, decimal price) : base(author, title, price)
        {

        }
    }
}