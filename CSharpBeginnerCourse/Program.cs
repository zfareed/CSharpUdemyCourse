using System;

namespace CSharpBeginnerCourse
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduction()
        {
            Console.WriteLine("My name is " + firstName + lastName );
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person prsn1 = new Person();
            prsn1.firstName = "zain";
            prsn1.lastName = "fareed";
            prsn1.Introduction();





        }
    }
}

