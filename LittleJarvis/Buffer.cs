using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected T [] bufferMtrx;

        public Buffer(int size)
        {
            bufferMtrx = new T[size];
        }

        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peek();

        public void Print()
        {
            {
                for (int i = 0; i < bufferMtrx.Length; i++)
                {
                    Console.WriteLine(bufferMtrx[i].ToString());
                }
                Console.WriteLine();
            }
        }

    }
}
