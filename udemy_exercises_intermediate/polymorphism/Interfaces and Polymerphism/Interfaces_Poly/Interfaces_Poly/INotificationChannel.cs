using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Poly
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}
