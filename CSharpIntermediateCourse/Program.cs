using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediateCourse
{

    public class PresentationObject           // Parent Class
    {
        public int width;
        public string Name;

        public void Copy()
        {
            Console.WriteLine("Text Coppied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Text Duplicated");
        }

    }

    public class Text : PresentationObject
    {
        public int textSize;
        public string textColor;


        public void HyperLink()
        {
            Console.WriteLine("Hyper Link Added");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            var text = new Text();
            text.textSize = 10;
            text.textColor = "Brown";
            text.Copy();
            text.Duplicate();
            Console.WriteLine("Text Size : " + text.textSize);
            Console.WriteLine("Text Color : " + text.textColor);

        }
    }
}
