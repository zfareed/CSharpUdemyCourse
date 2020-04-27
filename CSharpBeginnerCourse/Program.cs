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

            // Demo. Directory and DirectoryInfo

            Directory.CreateDirectory(@"c:/Documents/mydirectory");

            var files = Directory.GetFiles(@"C:\Users\Zain Fareed\Documents\DOC\New folder", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\Zain Fareed\Documents\DOC", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);


                if(Directory.Exists(@"C:\Users\Zain Fareed\Documents\DOC\New folder"))
                {
                    // do this
                }

                ////// Directory Info

                var directoryinfo = new DirectoryInfo(@"C:\Users\Zain Fareed\Documents\DOC\New folder");
                directoryinfo.GetFiles();
                directoryinfo.GetDirectories();

                


        }

    }
}

