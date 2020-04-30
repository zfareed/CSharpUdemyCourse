using System;

namespace CSharpIntermediateCourse
{

    public class Customer
    {
        public int Id;
        public string Name;

        public Customer(int ID)
        {
            this.Id = ID;
        }

        public Customer(int ID, string NAME)
        {
            this.Id = ID;
            this.Name = NAME;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer(3, "Zain");
            Console.WriteLine("ID : " + customer.Id);
            Console.WriteLine("Name : " + customer.Name);
            



        }
    }
}


