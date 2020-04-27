using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

namespace CSharpBeginnerCourse
{

   
    class Program
    {
        static void Main(string[] args)
        {

            // Demo. Path
            var path = @"C:\Users\Zain Fareed\Documents\DOC\Semester 6\OS\Lectures\Lecture1.pdf";

            Console.WriteLine("Extension : " + Path.GetExtension(path));
            Console.WriteLine("File Name : " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name : " + Path.GetDirectoryName(path));

                


        }

    }
}

