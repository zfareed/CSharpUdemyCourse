using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            // Demo. Array

            int[] array = new int[] { 3, 5, 7, 9, 6, 8 };

            //Lenght
            Console.WriteLine("Lenght of array :" + array.Length);

            //Indexof
            int index = Array.IndexOf(array, 6);
            Console.WriteLine("Index of 6 : " + index);


            //Clear
            Array.Clear(array, 1, 3);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            //Copy

            int[] array2 = new int[3];
            Array.Copy(array, array2, 3);

            Console.WriteLine("Array 2");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            //Sort
            Array.Sort(array);
            Console.WriteLine("Sorting array 1");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //reverse
            Array.Reverse(array);
            Console.WriteLine("Rversing array 1");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }



        }

    }
}

