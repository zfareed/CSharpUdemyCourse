using System;

namespace CSharpBeginnerCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 23. Opreators

            var a = 3;
            var b = 5;
            var c = 2;

            Console.WriteLine(a > b);
            Console.WriteLine(a < b && b < c);
            Console.WriteLine(a > b || b > c);
            Console.WriteLine(!(a != b));
            Console.WriteLine( a == c);

           
            
        }
    }
}

