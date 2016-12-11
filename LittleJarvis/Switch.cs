using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class Switch : Command
    {

        public Switch(): base ()
        {
            Name = "Switch";
            Pattern = "switch";
            Example = "switch on the light in the bathroom";
        }

        public override bool CanExec(string input)
        {
            string inputLower = input.ToLower();
            if (inputLower.StartsWith(Pattern+" on") || inputLower.StartsWith(Pattern+" off"))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public override void Action(string input)
        {
            string inputLower=input.ToLower();
            if (inputLower.StartsWith(Pattern + " on"))
            {
                Console.WriteLine("Ok, I'll {0} on {1}", Pattern, input.Remove(0, 10));
            }
            else if (inputLower.StartsWith(Pattern+" off"))
            {
                Console.WriteLine("Ok, I'll {0} off the {1}", Pattern, input.Remove(0, 11));
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
