using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender.Interfaces
{
    public interface IFormatter
    {
        IFormatter Initialize(IMessage message);        
        bool Validate();
        string Format();
    }
}
