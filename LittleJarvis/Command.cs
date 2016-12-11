using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    public abstract class Command : ICommand
    {
         
        public string Name { protected set;  get; }
        public string Example { protected set;  get; }
        public string Pattern { protected set; get; }

        public Command()
        {
            Name = "";
            Example = "";
            Pattern = "";
        }

        virtual public bool CanExec(string input)
        {
            string inputLower = input.ToLower();
            if (inputLower.StartsWith (Pattern))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public abstract void Action(string input);

    }
}
