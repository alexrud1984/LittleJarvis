using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class Executer:IExecuter
    {
        int logSize = 5; // remember last 5 commands in a log
        MyQueue<string> logQueue;
        Command[] com;

        public Executer()
        {
            logQueue = new MyQueue<string> (logSize);
            com = new Command[3];
            com[0] = new Switch();
            com[1] = new SendSMS();
            com[2] = new SendMail();
        }

        public void ExeCommand(string command)
        {
            bool commandDone = false;
            int i = 0;
            do
            {
                if (com[i].CanExec(command))
                {
                    com[i].Action(command);
                    logQueue.Enqueue(command);
                    commandDone = true;
                }
                i++;
            }
            while ((commandDone == false) && (i<com.Length));
            if (commandDone==false)
            {
                Console.WriteLine("Can not execute.");
            }
        }

        public void GetList()
        {
            Console.WriteLine("Name    Pattern");
            foreach (Command c in com)
            {
                Console.WriteLine("{0}      {1}", c.Name, c.Pattern);
            }
        }

        public void GetLog()
        {
            for (int i = 0; i < logQueue.Count; i++)
            {
                Console.WriteLine(logQueue.Dequeue());
            }
        }

        public void Example(string pattern)
        {
            for (int i = 0; i < com.Length; i++)
            {

                if (pattern.ToLower() == com[i].Pattern)
                {
                    Console.WriteLine("Example: "+ com[i].Example);
                    return;
                }
            }
            Console.WriteLine("There is no such command");
        }
    }
}
