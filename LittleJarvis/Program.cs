using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            Executer jarvis = new Executer();
            jarvis.GetList();
            jarvis.Example("switch");
            Console.ReadKey();

            Console.WriteLine();
            jarvis.ExeCommand("switch on the light in the room1");
            jarvis.ExeCommand("Switch on the light in the bathroom1");
            jarvis.ExeCommand("switch off the light in the room1");
            jarvis.GetLog();
            Console.ReadKey();

            Console.WriteLine();
            jarvis.ExeCommand("switch on the light in the room2");
            jarvis.ExeCommand("Switch on the light in the bathroom2");
            jarvis.ExeCommand("switch off the light in the room3");
            jarvis.ExeCommand("Switch off the light in the bathroom3");
            jarvis.GetLog();
            Console.ReadKey();

            Console.WriteLine();
            jarvis.Example("send sms");
            Console.ReadKey();

            Console.WriteLine();
            jarvis.ExeCommand("Send SMS to Jane with text 'How are you, Jane?'");
            jarvis.ExeCommand("Send SMS to Mark with text 'what are you doing, Mark?'");
            jarvis.ExeCommand("Send SMS to Mike with text 'Let's drink some beer'");
            jarvis.GetLog();
            Console.ReadKey();

            Console.WriteLine();
            jarvis.Example("send mail");
            jarvis.ExeCommand("Send mail to somebody with text 'something'");
            jarvis.ExeCommand("Send mail to somebody else with text 'something else'");
            jarvis.GetLog();
            Console.ReadKey();
        }
    }
}
