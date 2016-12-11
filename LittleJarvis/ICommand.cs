using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    interface ICommand
    {
        bool CanExec(string input);     //check if input command fit the command API
        void Action(string input);      //Action for the command
    }
}
