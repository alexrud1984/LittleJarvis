using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class SendSMS : Command
    {
        public SendSMS() : base()
        {
            Name = "SendSMS";
            Example = "send sms to Joe with text 'Hello Joe!'";
            Pattern = "send sms";
        }

        public override void Action(string input)
        {
            string inputLower = input.ToLower();
            if (inputLower.StartsWith(Pattern))
            {
                Console.WriteLine("Ok, I'll {0} {1}", Pattern, input.Remove(0, 9));
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

        }
    }
}
