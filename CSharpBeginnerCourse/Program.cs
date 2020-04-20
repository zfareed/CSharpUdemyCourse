using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises

            /* Q-2 - Write a program which takes two numbers from the console and displays the maximum
                of the two.*/

            Console.WriteLine("Enter Number_1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number_2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int greater_number;
            if (number1 > number2)
            {
                greater_number = number1;
            }
            else
            {
                greater_number = number2;
            }

            Console.WriteLine("Greater number is {0}", greater_number);



        }
 
    }
}

