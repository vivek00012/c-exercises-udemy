using System;

namespace EventsandDelegates
{
    public class MailService
    {

        public void OnvideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("Sending mail message.. " + e.video.Title);
        }
    }
}
