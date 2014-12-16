using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender.Interfaces
{
    public interface IRecipient
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string MobilePhone { get; set; }
    }
}
