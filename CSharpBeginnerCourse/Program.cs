using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            // 49. Exercises

            /* Q-1 - Write a program to count how many numbers between 1 and 100 are
                 divisible by 3 with no remainder.Display the count on the console.
 */

            
            int count = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " numbers are divisable by 3");


        }

    }
}

