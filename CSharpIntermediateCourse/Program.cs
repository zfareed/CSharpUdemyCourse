
namespace CSharpIntermediateCourse
{
    public abstract class Shape
    {
        public abstract void Draw();

        }
    public class Circle : Shape
    {
        public override void Draw()
        {
            /// implementation
            System.Console.WriteLine("Draw the circle");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           // var shape = new Shape();         // can't be created due to abstract class.
            var circle = new Circle();
            circle.Draw();


        }
    }
}
