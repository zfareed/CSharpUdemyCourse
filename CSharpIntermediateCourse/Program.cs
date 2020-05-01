using System;
using System.Collections.Generic;

namespace CSharpIntermediateCourse
{
    public class Customer
    {
        public int id;
        public string Name;
        public List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }

    public class Order
    {

    }

    

    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer(5);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);




        }
    }
}


