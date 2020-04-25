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

            /*Q-2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
                If the user simply presses Enter, without supplying an input, exit immediately;
            otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.*/


            Console.Write("Enter the numbers seprated by hypen : ");
            var numbers = Console.ReadLine();
            var list = new List<int>();

            var splitNUmbers = numbers.Split("-");

            foreach (var number in splitNUmbers)
            {
                int intNumber = Convert.ToInt32(number);
                list.Add(intNumber);
            }

            bool check = false;
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true)
                {
                    break;
                }
            }

            if (check == true)
            {
                Console.WriteLine("Duplicate");
            }



        }

    }
}

