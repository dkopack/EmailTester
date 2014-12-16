using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender.Interfaces
{
    public interface IMessage
    {
        IRecipient Recipient { get; set; }
        IFormatter MessageFormatter { get; }
        ITransport MessageTransport { get; }
        string Subject { get; set; }
        string Body { get; set; }
        void Send();
    }
}
