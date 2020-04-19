using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpBeginnerCourse
{

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3

    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.RegularAirMail;
            Console.WriteLine((int)method);

        }
    }
}

