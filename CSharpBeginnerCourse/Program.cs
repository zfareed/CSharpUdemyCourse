using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            int month = 4;

            switch (month)
                {

                case 1:
                    Console.WriteLine("Its Janaury");
                    break;
                case 2:
                    Console.WriteLine("Its Febraury");
                    break;
                case 3:
                    Console.WriteLine("Its March");
                    break;
                case 4:
                    Console.WriteLine("Its April");
                    break;
            }
          
        }
 
    }
}

