using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 0; i < 10; i++)
            {
                int number = i * 1;
                Console.WriteLine(number);
            }


            for (int i = 10; i > 0; i--)
            {
                int number2 = i * 1;
                Console.WriteLine(number2);
            }

        }

    }
}

