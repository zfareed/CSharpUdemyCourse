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
            dynamic number = 10;

            Console.WriteLine(number.GetType());

            int i = 5;
            dynamic d = i;
            long l = d;

            Console.WriteLine(l);


        }
    }
    

}


