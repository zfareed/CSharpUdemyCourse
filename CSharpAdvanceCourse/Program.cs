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

            var cheapbooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.Price < 10)
                {
                    cheapbooks.Add(book);
                }
            }
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title + " " + book.Price);
                }
            
        }
    }
    

}


