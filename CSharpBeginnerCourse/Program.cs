using System;
using System.Collections;
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
            // Summarizing Text

            var text = "This is going to be a very very very very long long string";
            var maxLenght = 20;
            var wordCounter = 0;
            var mylist = new List<string>();

            if (text.Length < maxLenght)
            {
                Console.WriteLine(text);
            }
            else
            {
                var splitText = text.Split(" ");

                foreach (var word in splitText)
                {
                    wordCounter += word.Length + 1;    // +1 for space
                    mylist.Add(word);
                    if (wordCounter > maxLenght)
                    {
                        break;
                    }

                }

                var summary = String.Join(" ",mylist) + "...";
                Console.WriteLine(summary);
            }




        }

    }
}

