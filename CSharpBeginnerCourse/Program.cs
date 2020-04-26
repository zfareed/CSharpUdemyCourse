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

            // Demo. File and FileInfo

            var path = @"c:\docs\myfile.txt";
            File.Copy(path,@"d:\\hello\file2.txx",true);

            if(File.Exists(path));
            {
                // perform this
            }
            File.Delete(path);

            File.Move(path,@"c://ok/this");

            var content = File.ReadAllText(path);


            FileInfo myfile = new FileInfo(path);
            myfile.Delete();
            if(myfile.Exists)
            {
                // do this
            }

            myfile.CopyTo("at this path");
            var lenght = myfile.Length;

            


        }

    }
}

