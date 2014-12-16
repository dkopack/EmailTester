using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MessageSender.Interfaces;

namespace MessageSender.Transports
{
    public class EmailTransport : ITransport
    {
        #region Properties

        private IMessage _message { get; set; }

        #endregion

        #region Public Methods

        public ITransport Initialize(IMessage message)
        {
            if(message != null)
            {
                _message = message;
                return this;
            }

            throw new ArgumentNullException("message", "Is Required");
        }

        public void Handle()
        {
            var mailMessage = new MailMessage(
                ConfigurationManager.AppSettings["DefaultFromAddress"], 
                _message.Recipient.Email, 
                _message.Subject,
                _message.MessageFormatter.Format());

            mailMessage.Body = _message.MessageFormatter.Format();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Send(mailMessage);
                }
            }
            catch(SmtpException)
            {
                Console.WriteLine("The SMTP Server is not propertly configured");
            }
        }

        #endregion
    }
}
