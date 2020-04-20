using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
           var number =  10;
            if (number > 0 && number <=12)
            {
                Console.WriteLine("Its Morning");
            }
            else if(number > 12 && number <= 18)
            {
                Console.WriteLine("Its Afternoon");
            }
            else
            {
                Console.WriteLine("Its Night");
            }


          
        }
 
    }
}

