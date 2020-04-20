using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBeginnerCourse
{
    public class Person
    {
        public int Age;
    }

   
    class Program
    {
        static void Main(string[] args)
        {

            var number = 1;
            Increament(number);
            Console.WriteLine(number);

            Person person = new Person() { Age = 10};
            AgeOld(person);
            Console.WriteLine(person.Age);

          
        }

        public static void Increament(int number)
        {
            number += 10;
        }

        public static void AgeOld(Person person)
        {
            person.Age += 20;
        }
    }
}

