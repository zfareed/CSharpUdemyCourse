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
            // Demo. Lists

            var numbers = new List<int>(){ 2 , 3 , 5, 6, 8, 9, 7 };
            
            //Add
            numbers.Add(10);
            numbers.AddRange(new int[3] { 12, 13, 14 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Indexof

            var index = numbers.IndexOf(8);
            Console.WriteLine("Index of 8 :" + index);

            //remove

            numbers.Remove(3);

            Console.WriteLine("List afte remove 3");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            //count

            Console.WriteLine("Count : " + numbers.Count);

            //clear

            numbers.Clear();
            Console.WriteLine("Count : " + numbers.Count);



        }

    }
}

