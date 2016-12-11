using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class CallBySkype : Command
    {
        public CallBySkype () : base()
        {
            Name = "CallBySkype";
            Example = "call by skype to Bob";
            Pattern = "call by skype";
        }

        public override void Action (string input)
        {
            string inputLower = input.ToLower();
            if (inputLower.StartsWith(Pattern))
            {
                Console.WriteLine("Ok, I'll {0} {1}", Pattern, input.Remove(0, 14));
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

        }

    }
}
