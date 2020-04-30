using System;

namespace CSharpIntermediateCourse
{


    public class Person
    {
        public string Name;

        public void Age(int age)
        {
            Console.WriteLine("Age of " + Name + " is " + age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            person.Name = "Zain";
            int age = 21;
            person.Age(age);



        }
    }
}


