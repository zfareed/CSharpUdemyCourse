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

            Console.WriteLine("Enter the height of Image : ");
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


        }
 
    }
}

