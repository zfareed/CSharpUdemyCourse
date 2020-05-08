using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharpAdvanceCourse
{

    public class Video
    {
        public string Title { get; set; }
    }


    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoencoder = new VideoEncoder();

            videoencoder.Encode(video);



        }

        
    }
}

