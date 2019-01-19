using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveProblems.LinkedList;

namespace SolveProblems.StackAndQueue
{
    class StackL<T>
    {
        private Node<T> top;
        
        public StackL()
        {
            this.top = null;
        }

        public int Size()
        {
            Node<T> p = this.top;
            int size  = 0;
            if(p != null)
            {
                size++;
                p= p.Next;
            }

            return size;
        }

        public void Push(T data)
        {
            Node<T> node = new Node<T>();
            node.Value = data;
            
            node.Next = top;
            top = node;
            
        }

        public T  Pop()
        {
            if(top == null)
            {
                throw new System.InvalidOperationException("Stack is empty");
            }

            Node<T> p = this.top;
            this.top = p.Next;

            return p.Value;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new System.InvalidOperationException("Stack is empty");
            }
            return this.top.Value;
        }

        public void DisPlay()
        {
            Node<T> p = this.top;

            while (p != null)
            {
                Console.WriteLine(p.Value);
                p = p.Next;
            }
        }
    }
}
