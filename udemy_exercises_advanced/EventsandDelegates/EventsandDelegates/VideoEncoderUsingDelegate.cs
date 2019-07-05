using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsandDelegates
{
    public class VideoEncoderUsingDelegate
    {
        //steps to publish a event ...
        //1-define a deligate
        //(A contract between a publisher and subscriber .
        //So a deligate determines the signature of a method in the subscriber that will be called when a publisher publishes a event)

        //2-Define a event based on the delegate...
        //3-Raise or publish the event.. 


        //Performin step 1

        //public delegate void VideoEncodedEventHandler(object source,EventArgs args); //refrence to the eventhandler in subscriber
        //arguments include source of the event to be publised ..
        //in case we want the subscribers to know the video to be encoded...create a VideoEventArgs class which derives from EventArgs...
        //the above delegate can be re-written as
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //creating a event based on the deligate..

        public event VideoEncodedEventHandler VideoEncoded;   

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
                VideoEncoded(this,new VideoEventArgs() { video = video });
        }






    }
}
