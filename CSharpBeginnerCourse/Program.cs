using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {

            // Exercises

            /* Q-1 - Write a program that reads a text file and displays the number of words.*/

            /*var text = File.ReadAllText(@"C:\Users\Zain Fareed\Documents\DOC\mytextfile.txt");
            Console.WriteLine(text);

            int numberOfWords = 0;
            var words = text.Split(" ");
            foreach (var word in words)
            {
                numberOfWords++;
            }

            Console.WriteLine("Number of words : " + numberOfWords);*/


            /*Q-2 - Write a program that reads a text file and displays the longest word in the file.*/

            var text = File.ReadAllText(@"C:\Users\Zain Fareed\Documents\DOC\mytextfile.txt");
            Console.WriteLine(text);

            var words = text.Split(" ");
            var wordList = new int[130];
            int i = 0;
             foreach (var word in words)
             {
                 var wordLenght = word.Length;
                 wordList[i] = wordLenght;
                 i++;
             }
            int longestWord = wordList.Max();
            int index = Array.IndexOf(wordList, longestWord);

            Console.WriteLine();
            Console.WriteLine("Longest Word : " + words[index]);




            
        }

    }
}

