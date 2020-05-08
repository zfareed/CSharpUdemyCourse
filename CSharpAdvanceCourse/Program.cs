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

            public Book this[int index]
            {
                get { throw new NotImplementedException(); }
            }
    }

    public class Book
        {
            /// mybook
        }


    public class GenericList<T>
    {
        public void Add(T number)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
            





    class Program
    {
        static void Main(string[] args)
        {

            /*var list = new List();
            list.Add(10);


            var books = new BooKList();
            books.Add(new Book());*/

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());


            

        }
    }
}
