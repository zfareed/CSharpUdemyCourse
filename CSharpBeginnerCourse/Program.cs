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
            // Strings

            var myname = "Zain Fareed ";

            Console.WriteLine(myname.Trim());   // trim whitespace

            Console.WriteLine(myname.ToLower());   // for lowecase

            Console.WriteLine(myname.ToUpper());    // for upercase

        }

    }
}

