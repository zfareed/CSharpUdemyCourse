using System;

namespace CSharpAdvanceCourse
{
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
    public class BooKList
    {
            public void Add(Book book)
            {
                throw new NotImplementedException();
            }

            public int this[int index]
            {
                get { throw new NotImplementedException(); }
            }
    }

    public class Book
        {
            /// mybook
        }
            





    class Program
    {
        static void Main(string[] args)
        {

            var list = new List();
            list.Add(10);


            var books = new BooKList();
            books.Add(new Book());


            

        }
    }
}
