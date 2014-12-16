using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageSender.Interfaces;

namespace MessageSender.Models
{
    public class Recipient : IRecipient
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }

        #endregion
    }
}
