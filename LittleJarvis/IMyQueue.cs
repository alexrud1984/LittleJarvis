using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    interface IMyQueue<T> : IBuffer<T>
    {
        void Enqueue(T value);
        T Dequeue();
    }
}
