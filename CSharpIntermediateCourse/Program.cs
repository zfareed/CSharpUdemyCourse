
namespace CSharpIntermediateCourse
{

    public class Vehicle
    {
        public Vehicle()
        {
            System.Console.WriteLine("Vehicle is being Initilazed");
        }
    }


    public class Car : Vehicle
    {
        public Car()
        {
            System.Console.WriteLine("Car is being Initilzed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            

        }
    }
}
