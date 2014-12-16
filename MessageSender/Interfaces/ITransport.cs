using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender.Interfaces
{
    public interface ITransport
    {
        ITransport Initialize(IMessage message);
        void Handle();
    }
}
