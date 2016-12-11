using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class SendMail : Command
    {
        public SendMail() : base()
        {
            Name = "SendMail";
            Example = "send mail to Joe with text 'I've got your present'";
            Pattern = "send mail";
        }

        public override void Action(string input)
        {
            string inputLower = input.ToLower();
            if (inputLower.StartsWith(Pattern))
            {
                Console.WriteLine("Ok, I'll {0} {1}", Pattern, input.Remove(0, 10));
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

        }

    }
}
