using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageSender.Formatters;
using MessageSender.Interfaces;

namespace MessageSender.Models
{
    public class Message : IMessage
    {
        #region Properties

        public IRecipient Recipient { get; set; }
        public ITransport MessageTransport { get; private set; }
        public IFormatter MessageFormatter { get; private set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        #endregion

        #region Constructors

        public Message(ITransport messageTransport)
        {
            Initialize(messageTransport, null);
        }

        public Message(ITransport messageTransport, IFormatter messageFormatter)
        {
            Initialize(messageTransport, messageFormatter);
        }

        #endregion

        #region Public Methods

        public void Send()
        {
            if (MessageFormatter.Validate())
            {
                MessageTransport.Handle();
            }
            else
            {
                //TODO: Log Invalid Message Event
            }
        }



        #endregion

        #region Private Methods

        private void Initialize(ITransport messageTransport, IFormatter messageFormatter)
        {
            if(messageTransport != null)
            {
                this.MessageTransport = messageTransport.Initialize(this);
            }
            else
            {
                throw new ArgumentNullException("messageTransport", "Is Required");
            }

            if(messageFormatter != null)
            {
                this.MessageFormatter = messageFormatter.Initialize(this);
            }
            else
            {
                this.MessageFormatter = new EmailFormatter().Initialize(this);
            }

        }

        #endregion
    }
}
