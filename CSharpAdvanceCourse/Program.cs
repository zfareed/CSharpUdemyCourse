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
        public delegate void VideoEncoderEventHandler(object source, EventArgs argd);
        public event VideoEncoderEventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoencoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber

            videoencoder.VideoEncoded += mailService.OnVideoEncoded;

            videoencoder.Encode(video);



        }

        public class MailService
        {
            public void OnVideoEncoded(object source, EventArgs agrs)
            {
                Console.WriteLine("Mail Sevice Sending...");
            }
        }

        
    }
}

