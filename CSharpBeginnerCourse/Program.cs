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

            /* Q-4 - Write a program and ask the user to enter a few words separated by a space.
                 Use the words to create a variable name with PascalCase. For example, if the
                 user types: "number of students", display "NumberOfStudents".Make sure that the
                 program is not dependent on the input.So, if the user types "NUMBER OF STUDENTS",
                 the program should still display "NumberOfStudents
                 */

            Console.Write("Enter some words : ");
            var words = Console.ReadLine();

            //string PascalCase;
             var wordsString = words.Split(" ");
           


            var PascalCase = String.Join("",wordsString);
            Console.WriteLine(PascalCase);


             


            


        }

    }
}

