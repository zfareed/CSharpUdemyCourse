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

            /* Q-3 - Write a program and ask the user to enter a time value in the 24 - hour time
                 format(e.g. 19:00). A valid time should be between 00:00 and 23:59.If the time is
                 valid, display "Ok"; otherwise, display "Invalid Time".If the user doesn't provide
                 any values, consider it as invalid time.*/

            Console.Write("Enetr 24 hour time format (e.g. 19:00) ");
            var time = Console.ReadLine();

            var mytime = time.Split(":");
            var hour = Convert.ToInt32(mytime[0]);
            var minute = Convert.ToInt32(mytime[1]);


            if( hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            {
                Console.WriteLine("Valid Time");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }





        }

    }
}

