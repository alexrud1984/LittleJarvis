using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int tail = 0;
        private int head = 0;
        public int Count  { private set; get; }

        public MyQueue(int size) : base(size) { }

        public override bool IsEmpty()       //check if buffer is empty - counter is 0
        {
            if (Count == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public override bool IsFull()        //check if buffer is full - counter = size of buffer
        {
            if (Count == bufferMtrx.Length)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }


        public void Enqueue(T value)                    //put new value in queue
        {
            if (IsFull())
            {
                Count--;
                head = tail + 1;
                if (head == bufferMtrx.Length)          //move head to beginning of matrix if it is out of range
                {
                    head = 0;
                }
            }
            bufferMtrx[tail] = value;           
            tail++;                                 //move tail to next cell
            Count++;                                //increase counter of elements
            if (tail == bufferMtrx.Length)          //move tail to beginning of matrix if it is out of range
            {
                tail = 0;
            }   
        }

        public T Dequeue()
        {
            int pointer = head;                         //remember current head position
            if (IsEmpty())
            {
                return (default (T));                    //return exc. if queue is empty
            }
            else
            {
                head++;                                 //move head to next cell
                if (head == bufferMtrx.Length)          //move head to beginning of matrix if it is out of range
                {
                    head = 0;
                }
                return (bufferMtrx[pointer]);
            }
        }

        public override T Peek()
        {
            throw new NotImplementedException();
        }

    }
}
