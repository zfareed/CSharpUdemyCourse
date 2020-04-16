using System;

namespace CSharpBeginnerCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 20. Demo Type Conversion

            string number = "12345";
            int mynumber = Convert.ToInt32(number);
            Console.WriteLine(mynumber);
        }
    }
}

