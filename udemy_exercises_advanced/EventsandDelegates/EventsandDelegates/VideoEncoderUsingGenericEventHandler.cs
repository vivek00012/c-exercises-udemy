using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsandDelegates
{
    public class VideoEncoderUsingGenericEventHandler
    {


        //using generic event handler

        public EventHandler<VideoEventArgs> VideoEncoded;
  

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            //calling a event publisher method

            OnVideoEncoded(video);

        }

        //creating a eventpublisher method..

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { video = video });
        }





    }
}
