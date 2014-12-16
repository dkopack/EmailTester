using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageSender.Models;
using MessageSender.Transports;
using MessageSender.Formatters;


namespace EmailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipient = new Recipient()
            {
                Email = "david@dmkdata.net",
                FirstName = "David",
                LastName = "Kopack"
            };

            var testMessage = new Message(new EmailTransport());
            testMessage.Recipient = recipient;
            testMessage.Body = "Test message body";

            testMessage.Send();

            var testUglyMessage = new Message(new EmailTransport(), new UglyEmailFormatter());
            testUglyMessage.Recipient = recipient;
            testUglyMessage.Body = "Test ugly message body";

            testUglyMessage.Send();
        }
    }
}
