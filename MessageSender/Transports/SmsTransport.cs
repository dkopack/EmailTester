using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageSender.Interfaces;

namespace MessageSender.Transports
{
    public class SmsTransport : ITransport
    {
        #region Properties

        private IMessage _message { get; set; }

        #endregion

        #region Public Methods

        public ITransport Initialize(IMessage message)
        {
            if (message != null)
            {
                _message = message;
                return this;
            }

            throw new ArgumentNullException("message", "Is Required");
        }

        public void Handle()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
