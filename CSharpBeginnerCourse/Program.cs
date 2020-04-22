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




            /*Q-3 - Write a program and ask the user to enter a number. Compute the factorial of the
                number and print it on the console. For example, if the user enters 5, the program
                should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/

            /* int number;
             Console.Write("Enter the number : ");
             number = Convert.ToInt32(Console.ReadLine());

             int factorialSum = 1;
             for (int i = 1; i <= number  ; i++)
             {
                 factorialSum = factorialSum * i; 
             }

             Console.WriteLine(number + "! = " + factorialSum);*/


            /*Q-4 - Write a program that picks a random number between 1 and 10.Give the user 
                chances to guess the number.If the user guesses the number, display
                “You won"; otherwise, display “You lost". (To make sure the program is behaving
                 correctly, you can display the secret number on the console first.)*/



            Console.Write("Guess the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            var ranNumber = new Random();
            int myrand = ranNumber.Next(1, 10);
            //ranNumber = Convert.ToInt32();
            Console.WriteLine("Random number is " + myrand);

            if (number == myrand)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You Lose");
            }






        }

    }
}

