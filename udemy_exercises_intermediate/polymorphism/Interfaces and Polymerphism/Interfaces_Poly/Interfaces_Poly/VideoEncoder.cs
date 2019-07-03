using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Poly
{

    //OCP(OPEN CLOSE PRINCIPLE):A software is open to extension(we create new implementation of inotification channel) and close to modification...
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;  
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //video Enoding Logic
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }

        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
