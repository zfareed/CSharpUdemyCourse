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

            Console.WriteLine(myname.IndexOf("i"));  // index of any character

            Console.WriteLine(myname.LastIndexOf("Fareed"));  // check last index of string

            var index = myname.IndexOf(" ");                  // for substring
            var fName = myname.Substring(0,index);
            var lNmae = myname.Substring(index+1);
            Console.WriteLine("First Name : " + fName);
            Console.WriteLine("Last Name : " + lNmae);

            var split = myname.Split(" ");                     // split method (split the string into 2 halves and store in string array)
            Console.WriteLine("F Name : " + split[0]);
            Console.WriteLine("L Name : " + split[1]);

            Console.WriteLine(myname.Replace("Zain", "Zafar"));     // replace method
            Console.WriteLine(myname.Replace("a", "A"));


            if (String.IsNullOrWhiteSpace(" "));                    // isNUllorEmpty   //isNuLLorWhiteSpace
            {
                Console.WriteLine("Invalid");
            }


            var str = "25";                          // string to int
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 34.45f;                  // float to str
            Console.WriteLine(price);
            var myprice = price.ToString("C");
            Console.WriteLine(myprice);



        }

    }
}

