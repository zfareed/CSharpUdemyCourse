using System;

namespace CSharpBeginnerCourse
{

    class Program
    {
        static void Main(string[] args)
        {
            string fNmae = "zain";
            string lNmae = "fareed";

            Console.WriteLine(fNmae);
            Console.WriteLine(lNmae);
            Console.WriteLine(fNmae + " " + lNmae);

            string fullNmae = string.Format("My name is {0} {1}", fNmae, lNmae);
            Console.WriteLine(fullNmae);

            string myfullNmae = string.Format("My name is {1} {0}", fNmae, lNmae);
            Console.WriteLine(myfullNmae);


            string[] names = new string[3] { "zain", "ahmad", "akbar" };
            string mynames = string.Join(',', names);
            Console.WriteLine(mynames);

            // Verbanium Strings
            Console.WriteLine("Hi Ahmad look at these links\nc://documents//folder1\nc://music//folder2");
            Console.WriteLine(@"Hi Ahmad look at these links
c:/documents/folder1
c:/music/folder2");


        }
    }
}

