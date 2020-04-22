using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            // 56. Exercises

            /*Q-1 - When you post a message on Facebook, depending on the number of people who like your post,
             Facebook displays different information.

                 If no one likes your post, it doesn't display anything.
                 If only one person likes your post, it displays: [Friend's Name] likes your post.
                 If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
                 If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number
                     of Other People] others like your post.
                 Write a program and continuously ask the user to enter different names, until the user
                     presses Enter (without supplying a name). Depending on the number of names provided,
                 display a message based on the above pattern.*/





            /* Q-2 - Write a program and ask the user to enter their name. Use an array to reverse the
                 name and then store the result in a new string.Display the reversed name on the console.*/


            /*Console.Write("Enter the name : ");
            var name = Console.ReadLine();

            char[] array = new char[10];
            int i = 0;
            foreach (char character in name)
            {
                array[i] = character;
                i++;
            }

            Array.Reverse(array);

            string newName = new string(array);
            Console.WriteLine("Reverse Name : " + newName);*/



            /*Q-3 - Write a program and ask the user to enter 5 numbers.If a number has been previously
                entered, display an error message and ask the user to re-try. Once the user successfully
                enters 5 unique numbers, sort them and display the result on the console.*/


            int[] array = new int[5] { 0,0,0,0,0};
            int j = 0;
            int counter = 0;
            bool repeat = false;
            while (true)
            {
                Console.Write("Enter the number : ");
                int number = Convert.ToInt32(Console.ReadLine());

                foreach (var num in array)
                {
                    if (number == num)
                    {
                        Console.WriteLine(num + " is previously entered, enter a unique number");
                        repeat = true;
                    }

                }

                if (repeat == false)
                {


                    array[j] = number;
                    j++;
                    counter++;
                    if (counter == 5)
                    {
                        break;
                    }

                }
                repeat = false;
            }

           
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }

    }
}

