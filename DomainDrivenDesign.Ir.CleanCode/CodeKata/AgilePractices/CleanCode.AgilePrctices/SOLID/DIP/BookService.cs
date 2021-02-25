using System;

namespace CleanCode.AgilePractices.SOLID.DIP
{
    internal class IsbnGenerator : IBookIdGenerator
    {
        public string GenerateNumber()
        {
            return "13-84356-" + Math.Abs(new Random().Next());
        }
    }

    public interface IBookIdGenerator
    {
        string GenerateNumber();
    }

    public class BookService
    {
        private readonly IBookIdGenerator _isbnGenerator;

        public BookService(IBookIdGenerator isbnGenerator)
        {
            _isbnGenerator = isbnGenerator;
        }

        public void CreateBook(string title)
        {
            var book = new Book(title, _isbnGenerator.GenerateNumber());
            //Store the book
        }
    }

   

    public class Book
    {
        private readonly string _title;
        private readonly string _number;

        public Book(string title, string number)
        {
            _title = title;
            _number = number;
        }
    }
}
