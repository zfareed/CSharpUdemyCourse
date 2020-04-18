using System;

namespace CSharpBeginnerCourse
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 10;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            bool[] isTrue = new bool[3];
            isTrue[0] = true;

            Console.WriteLine(isTrue[0]);
            Console.WriteLine(isTrue[1]);
            Console.WriteLine(isTrue[2]);


            string[] names = new string[3] {"zain" , "fareed" , "ahmad" };
            //names[0] = "zain";

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
           
        }
    }
}

