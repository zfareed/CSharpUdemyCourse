using System;

namespace CSharpAdvanceCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));


        }

        static int Square(int number)
        {
            return number * number;
        }
        
    }
}

