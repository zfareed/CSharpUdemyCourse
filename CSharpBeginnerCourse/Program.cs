using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 10;
            var value2 = value1;
            value2++;
            Console.WriteLine(string.Format("value1 : {0} , value2 : {1}", value1, value2));


            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 5;
            Console.WriteLine(string.Format("array1[0] : {0} , array2[1] : {1}", array1[0], array2[0]));

        }
    }
}

