using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSharpAdvanceCourse
{

    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Opreators
            var book = books.Single(b => b.Title == "ASP.NET MVC");
            var book1 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC 2");
            var book2 = books.First(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(book.Title);
            Console.WriteLine(book1 == null);
            Console.WriteLine(book2.Title +" " + book2.Price);


            var pagedBooks = books.Skip(2).Take(3);

            foreach (var pagebook in pagedBooks)
            {
                Console.WriteLine(pagebook.Title);
            }
        }
    }
    

}


