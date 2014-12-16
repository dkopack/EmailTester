using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MessageSender.Interfaces;

namespace MessageSender.Formatters
{
    public class EmailFormatter : IFormatter
    {
        #region Properties

        protected IMessage Message { get; set; }
        private HashSet<string> _requiredFields = new HashSet<string>() { "Recipient", "Body" };

        #endregion

        #region Public Methods

        public IFormatter Initialize(IMessage message)
        {
            if (message != null)
            {
                Message = message;
                return this;
            }

            throw new ArgumentNullException("message", "Is Required");
        }

        public virtual string Format()
        {
            return string.Format("<p>{0}</p>", Message.Body);
        }

        public virtual bool Validate()
        {
            foreach(var property in Message.GetType().GetProperties())
            {
                if (_requiredFields.Contains(property.Name) && property.GetValue(Message) == null)
                {
                    return false;
                }
            }

            return true;  
        }

        #endregion
    }
}
