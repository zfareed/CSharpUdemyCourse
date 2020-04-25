using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
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

            /*Q-5 - Write a program and ask the user to enter an English word.Count the number
                of vowels(a, e, o, u, i) in the word. So, if the user enters "inadequate", the
                program should display 6 on the console.*/


            Console.Write("Enter a word : ");
            var word = Console.ReadLine();
            int counter = 0;

            foreach (var character in word)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);









        }

    }
}

