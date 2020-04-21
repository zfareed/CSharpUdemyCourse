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


            /* int count = 0;

             for (int i = 1; i < 100; i++)
             {
                 if (i%3 == 0)
                 {
                     count++;
                 }
             }
             Console.WriteLine(count + " numbers are divisable by 3");
 */


            /* Q-2 - Write a program and continuously ask the user to enter a number or
                 "ok" to exit. Calculate the sum of all the previously entered 
                 and display it on the console.*/

            int add = 0;
            int int_number;
            string number;
            
            while (true)
            {
                Console.WriteLine("Enter a number or write 'ok' to exit");
                number = Console.ReadLine();

                if (number == "ok")
                {
                    Console.WriteLine(add);
                    break;
                }
                else
                {
                    int_number = Convert.ToInt32(number);
                    add = add + int_number;

                }
            }



        }

    }
}

