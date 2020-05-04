using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateCourse
{
    public class Customer
    {
        public int Id;
        public int Name;

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                System.Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                System.Console.WriteLine("Promoted to level 2");
            }
        }

        public int CalculateRating()
        {
            return 0;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.CalculateRating();


        }
    }
}
