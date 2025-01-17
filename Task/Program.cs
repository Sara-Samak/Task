using Task.Classes;
using Task.Struct;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Gentelman Burglar", "Arsene Lupin", "1230");
            BorrowedBook borrowedBook = new BorrowedBook(1, book, "sara", DateTime.Now.AddDays(-5));

            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {borrowedBook.BookDetails.Title}");
            Console.WriteLine($"Author: {borrowedBook.BookDetails.Author}");
            Console.WriteLine($"ISBN: {borrowedBook.BookDetails.ISBN}");

            borrowedBook.CheckOut();

            int borrowDuration = borrowedBook.CalculateBorrowDuration();
            Console.WriteLine($"The book has been borrowed for {borrowDuration} days.");

            borrowedBook.ReturnItem();
        }
    }
}
