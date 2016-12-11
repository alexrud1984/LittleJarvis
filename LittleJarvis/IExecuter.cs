using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    interface IExecuter
    {
        void ExeCommand(string command);
        void GetList();
        void Example(string pattern);
        void GetLog();
    }
}
