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


           

            var nameList = new List<string>();

            while (true)
            {
                Console.Write("Enter the name : ");
                var name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                else
                {
                    nameList.Add(name);
                }
            }

            int counter = nameList.Count();
            if (counter == 0)
            {
                Console.WriteLine(" ");
            }
            else if (counter == 1)
            {
                Console.WriteLine(nameList[0] + " likes your post");
            }
            else if (counter == 2)
            {
                Console.WriteLine(nameList[0] + " and " + nameList[1] + " likes your post");
            }
            else
            {
                Console.WriteLine(nameList[0] + " , " + nameList[1] + " and " + (counter-2) + " others likes your post" );

            }


        }

    }
}

