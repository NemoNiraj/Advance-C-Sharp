using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Delegate
        // 1 - Define a Delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event
        // syntax for delegat - "Access_specifier delegate

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        // EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
