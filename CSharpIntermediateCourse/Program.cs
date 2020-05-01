using System;
using System.Collections.Generic;

namespace CSharpIntermediateCourse
{
    public class Person
    {
        private DateTime _birthday;

        public void setBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }

        public DateTime getBirthday()
        {
            return _birthday;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            person.setBirthday(new DateTime(2019, 1, 1));
            Console.WriteLine(person.getBirthday());





        }
    }
}


