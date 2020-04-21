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

            /* Q-3 - Write a program and ask the user to enter the width and height of an image.
                Then tell if the image is landscape or portrait.*/

            /* Console.WriteLine("Enter the height of Image : ");
             int height = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the width of Image : ");
             int width = Convert.ToInt32(Console.ReadLine());

             if (height > width)
             {
                 Console.WriteLine("Your Image is portrait");
             }
             else if (width > height)
             {
                 Console.WriteLine("Your Image is Landscape");
             }
             else
             {
                 Console.WriteLine("Your Image is Square");
             }


 */


            /* Q-4 - Your job is to write a program for a speed camera.For simplicity, ignore the
                details such as camera, sensors, etc and focus purely on the logic.Write a program
                that asks the user to enter the speed limit.Once set, the program asks for the speed
                    of a car.If the user enters a value less than the speed limit, program should
                    display Ok on the console.If the value is above the speed limit, the program
                    should calculate the number of demerit points.For every 5km / hr above the speed
                    limit, 1 demerit points should be incurred and displayed on the console.If the
                    number of demerit points is above 12, the program should display License Suspended.*/


            Console.WriteLine("Enter the speed limit : ");
            int  speed_limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of car : ");
            int speed = Convert.ToInt32(Console.ReadLine());

            if ( speed < speed_limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demritPoints = (speed - speed_limit) / 5;

                if (demritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demrit Points = {0}",demritPoints);
                }
            }




        }

    }
}

