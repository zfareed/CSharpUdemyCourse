using System;

namespace CSharpBeginnerCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0},{1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0},{1}", long.MinValue, long.MaxValue);
            Console.WriteLine("{0},{1}", char.MinValue, char.MaxValue);
            Console.WriteLine("{0},{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0},{1}", double.MinValue, double.MaxValue);
        }
    }
}

