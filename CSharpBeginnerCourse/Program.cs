using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            // random class

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 20));
            }


            var myrandom = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + myrandom.Next(0, 26)));
            }



            var array = new char[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = (char)('a' + myrandom.Next(0, 26));
            }

            var password = new string(array);

            Console.WriteLine("\n" + password);




        }

    }
}

