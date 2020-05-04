
namespace CSharpIntermediateCourse
{

    public class Vehicle
    {
        private readonly string registerationNumber;

        /*public Vehicle()
        {
            System.Console.WriteLine("Vehicle is being Initilazed");
        }*/

        public Vehicle(string registerationNumber)
        {
            this.registerationNumber = registerationNumber;

            System.Console.WriteLine("Vehicle is being initilazed {0}",registerationNumber);
        }
    }


    public class Car : Vehicle
    {
        public Car(string registrationNUmber)
            : base(registrationNUmber)
        {
            System.Console.WriteLine("Car is being Initilzed {0}",registrationNUmber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ1234");
            

        }
    }
}
