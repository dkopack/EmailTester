using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender.Formatters
{
    public class UglyEmailFormatter : EmailFormatter
    {
        public override string Format()
        {
            return string.Format("<p style=\"color:purple;\">{0}</p>", Message.Body);
        }
    }
}
