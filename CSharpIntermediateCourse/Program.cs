using System;
using System.Collections.Generic;

namespace CSharpIntermediateCourse
{

    public class Person
    {
        public DateTime birthday { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - birthday;
                var years = timeSpan.Days / 365;

                return years;
            }    
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            person.birthday = new DateTime(1990, 1, 1);
            Console.WriteLine(person.Age);






        }
    }
}


