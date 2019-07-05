using System;

namespace EventsandDelegates
{
    public class TextService
    {

        public void OnvideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("Sending text message.. " + e.video.Title);
        }
    }
}
