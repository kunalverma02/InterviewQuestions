using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveProblems.LinkedList;

namespace SolveProblems.StackAndQueue
{
    class QueueL<T>
    {
        public Node<T> First;
        public Node<T> Last;

        public QueueL()
        {
            this.First = null;
            this.Last = null;
        }

        public T Peek()
        {
            if(this.First == null)
            {
                throw new System.InvalidOperationException("Queue is empty");
            }
            return this.First.Value;
        }

        public void Enqueue(T value)
        {
            Node<T> p = new Node<T>();
            p.Value = value;

            if( First == null)
            {
                First = p;
                Last = p;
            }
            else
            {
                this.Last.Next = p;
                this.Last = p;
            }
        }

        public T Dequeue()
        {
            if (this.First == null)
            {
                throw new System.InvalidOperationException("Queue is empty");
            }
            Node<T> p = this.First;
            this.First = this.First.Next;
            return p.Value;
        }

        public void Display()
        {
            Node<T> p = this.First;

            while(p!=null)
            {
                Console.WriteLine(p.Value);
                p = p.Next;
            }
        }
    }
}
