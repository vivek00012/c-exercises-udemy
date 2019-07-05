using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{

    class Program
    {
        static void Main(string[] args)
        {
            //Events:
            //A mechanism for communication between objects..
            //Used in bulding loosely coupled applications..
            //Helps extending applications..


            //in this excercise we have video encoder(which is responsible for encoding the video) and mail service . 
            //These two classes are de-coupled from each other ..


            //Publishing and subscribing to events..

            //VideoEncoder had VideoEncoded event which is published(publisher or  event sender) for the mail service
            //or sms service to subscribe(subscriber-event receiver).

      

     
            //using delegate and event 
           // var VideoEncoder = new VideoEncoderUsingDelegate();

            //using event handler...
            var VideoEncoder = new VideoEncoderUsingGenericEventHandler();

            //giving event refrences to the method name of subscribers...signature definations are already referenced via deligate and arguments of the publisher event supplied has of same defined type..
            VideoEncoder.VideoEncoded+=new MailService().OnvideoEncoded;
             VideoEncoder.VideoEncoded += new TextService().OnvideoEncoded;

            VideoEncoder.Encode(new Video() { Title = "Book123" });




        }
    }
}
