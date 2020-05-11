using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSharpAdvanceCourse
{

    class Program
    {
        static void Main(string[] args)
        {

            DateTime? date = null;

            Console.WriteLine("Get value or default :" + date.GetValueOrDefault());
            Console.WriteLine("Has Value :" + date.HasValue);
            Console.WriteLine("Value " + date.Value);   //program crash becasue it doesnot have value

            DateTime date2 = date.GetValueOrDefault();

            Console.WriteLine(date2);

            DateTime date3 = date2;

            Console.WriteLine(date3);
        }
    }
    

}


