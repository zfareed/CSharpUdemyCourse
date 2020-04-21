using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Zain Fareed";

            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }*/


            foreach (var character in name)
            {
                Console.WriteLine(character);
            }


            var array = new int[5] { 2, 5, 7, 9, 11 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
           

        }

    }
}

