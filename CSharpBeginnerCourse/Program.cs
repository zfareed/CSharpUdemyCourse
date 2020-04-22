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
            // Date and Time

            TimeSpan timeSpan = new TimeSpan(1,2,3);

            Console.WriteLine(timeSpan);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var timeSpan2 = end - start;

            Console.WriteLine(timeSpan2);


            Console.WriteLine(timeSpan.ToString());

        }

    }
}

