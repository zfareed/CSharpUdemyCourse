using System;

namespace CSharpBeginnerCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 20. Demo Type Conversion

            try
            {
                string number = "hello";
                bool mynumber = Convert.ToBoolean(number);
                Console.WriteLine(mynumber);

            }
            catch (Exception)
            {

                Console.WriteLine("Number cannot be converted");
            }

            
        }
    }
}

