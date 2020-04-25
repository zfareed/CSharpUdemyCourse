using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {
            // Demo. SrringBuilder

            //Best for string manipulation   
            var string_builder = new StringBuilder();
            string_builder.Append('-', 10);
            string_builder.AppendLine();
            string_builder.Append("Header");
            string_builder.AppendLine();
            string_builder.Append('-', 10);
            string_builder.Replace('-','+');
            string_builder.Remove(0,10);
            string_builder.Insert(0,new string('-', 10));
            Console.WriteLine(string_builder);

            Console.WriteLine(string_builder[0]);


        }

    }
}

