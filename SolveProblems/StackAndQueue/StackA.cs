using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.StackAndQueue
{
    class StackA
    {
        private int top;
        private int bottom;
        private int [] stackArray;
        
        public StackA(int size)
        {
            stackArray = new int[size];
            this.top = -1;
        }

        public bool IsStackFull()
        {
            if(this.stackArray.Length<= this.top + 1)
            {
                return true;
            }
            return false;
        }

        public bool IsStackEmpty()
        {
            if(top ==-1)
            {
                return true;
            }
            return false;
        }

        public void Push(int n)
        {
            if (IsStackFull())
            {
                Console.WriteLine("Stack will overflow");
            }
            else
            {
                top++;
                stackArray[top] = n;
            }
        }

        public int Pop()
        {
            if(IsStackEmpty())
            {
               throw new System.InvalidOperationException("Stack is empty");
            }
            int x = stackArray[top];
            top--;
            return x;
        }

        public int Peek()
        {
            if(! IsStackEmpty())
            {
                return stackArray[top];
            }

            throw new System.InvalidOperationException("Stack is empty");
        }

    }
}
