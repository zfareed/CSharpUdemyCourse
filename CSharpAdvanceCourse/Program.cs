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
            var cheaperbooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


              // these are LINQ Extension Methods
            var cheapbooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            
                foreach (var book in books)
                {
                Console.WriteLine(book);
                    //Console.WriteLine(book.Title + " " + book.Price);
                }
            
        }
    }
    

}


