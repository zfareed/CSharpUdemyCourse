using System;

namespace CSharpAdvanceCourse
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public class Photo
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            var photo = new PhotoFilters();
            photo.ApplyBrightness(new Photo());
            photo.ApplyBrightness(new Photo());
            photo.Resize(new Photo());




            

        }
    }
}
