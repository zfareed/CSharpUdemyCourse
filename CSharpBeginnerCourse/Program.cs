using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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



            /*Console.Write("Guess the number : ");
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

*/



            /* Q-5 - Write a program and ask the user to enter a series of numbers separated by
                 comma.Find the maximum of the numbers and display it on the console.
                 For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/



            Console.Write("Enter a series of number seprated by comma : ");
            var numbers = Console.ReadLine();

            int[] array = new int[10];
            int int_number;
            int j = 0;

            foreach (char number in numbers)
            {
                if (Char.IsDigit(number))
                {
                    int_number = Convert.ToInt32(number);
                    array[j] = int_number - 48;           // assci value of numbers start from 48. so we minus 48 for original numeric value.
                    j++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
                
            }
            Console.WriteLine("Max Value :" + array.Max());



        }

    }
}

