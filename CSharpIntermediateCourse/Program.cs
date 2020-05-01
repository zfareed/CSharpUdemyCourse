using System;

namespace CSharpIntermediateCourse
{

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;

        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(0, 1);
            Console.WriteLine(point.X + " " +  point.Y);

            point.Move(10, 20);
            Console.WriteLine("The dot is at point ({0},{1})",point.X,point.Y);

            point.Move(new Point(40,50));
            Console.WriteLine("The dot is at point ({0},{1})",point.X,point.Y);





        }
    }
}


