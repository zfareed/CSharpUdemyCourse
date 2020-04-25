using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {

            // Exercises

            /* Q-1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
                 Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or
                 "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".*/

            Console.Write("Enter the numbers seprated by hypen : ");
            var numbers = Console.ReadLine();
            var list = new List<int>();

            var splitNUmbers = numbers.Split("-");

            foreach (var number in splitNUmbers)
            {
                int intNumber = Convert.ToInt32(number);
                list.Add(intNumber);
            }


            var fIndex = list[0];
            var lIndex = list[list.Count-1];
            var length = list.Count;

            if ((fIndex+(length-1)) == lIndex)
            {
                Console.WriteLine("Consectuive");
            }
            else
            {
                Console.WriteLine("Non-Consectuive");
            }



        }

    }
}

