using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number < 10)
            {
                Console.WriteLine("Hello World");

                number++;
            }


            int mynumber = 1;              // skiping number 7 (use of continue)
            while (mynumber < 10)
            {
                if (mynumber == 7)
                {
                    mynumber++;
                    continue;
                }
                else
                {
                    Console.WriteLine(mynumber);
                }
                mynumber++;
                
            }
           

        }

    }
}

