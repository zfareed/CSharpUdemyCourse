
namespace CSharpIntermediateCourse
{
    public class Shape
    {
        public int Width;
        public int Height;
        public int pos_X;
        public int pos_Y;

        public void Draw()
        {

        }

    }


    public class Text : Shape
    {
        public int textSize;
        public string textColor;



    }



    class Program
    {
        static void Main(string[] args)
        {
             var text = new Text();         //text and shape both are refering to same object in the memory
             Shape shape = text;

            text.Width = 100;
            shape.Width = 200;


            System.Console.WriteLine(text.Width);


            //Downcasting

            Shape myshape = new Text();
            Text mytext = (Text)myshape;
            




        }
    }
}
