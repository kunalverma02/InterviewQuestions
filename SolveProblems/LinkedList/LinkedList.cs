using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Length;

        public SinglyLinkedList()
        {
            this.Head = null;
            this.Tail = this.Head;
            this.Length = 0;
        }

        public void Append(T value)
        {
            Node<T> P = new Node<T>();
            P.Value = value;
            P.Next = null;

            if(this.Length == 0)
            {
                this.Head = P;
                this.Tail = Head;
            }
            else
            {
                Tail.Next = P;
                Tail = P;
            }
            
            this.Length++;
        }

        public int? Search(T data)
        {
            Node<T> P = this.Head;
            int? count = 1;
            while(P !=null)
            {
                if(P.Value.ToString() == data.ToString())
                {
                    return count;
                }
                P = P.Next;
                count++;
            }
            return null;
        }

        public void Display()
        {
            Node<T> P = this.Head;
            while(P !=null)
            {
                Console.WriteLine(P.Value);
                P = P.Next;
            }
        }

        public void InsertAfter(Node<T> node, Node<T> newNode)
        {
            Node<T> P = this.Head;

            while(P!=null)
            {
                if(P.Value.ToString() == node.Value.ToString())
                {
                    newNode.Next = P.Next;
                    P.Next = newNode;
                    this.Length++;
                    break;
                }
                P = P.Next;
            }
        }

        public void InsertBefore(Node<T> node, Node<T> newNode)
        {
            Node<T> P = this.Head;
            while(P!=null)
            {
                if(P.Next.Value.ToString() == node.Value.ToString())
                {
                    newNode.Next = P.Next;
                    P.Next = newNode;
                    this.Length++;
                    break;
                }
                P = P.Next;
            }
        }

        public void InsertAtStart(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            node.Next = this.Head;
            this.Head = node;
            this.Length++;
        }

        public void InsertAt(int position,  T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;

            Node<T> P = this.Head;
            for(int i =1; i<position; i++)
            {
                if(i +1 == position)
                {
                    node.Next = P.Next;
                    P.Next = node;
                    this.Length++;
                    break;
                }
                P = P.Next;
            }
        }

        public void RemoveAtStart()
        {
            this.Head = this.Head.Next;
        }

        public void RemoveDuplicatesFromLinkedList()
        {
            Node<T> P = this.Head;
            List<T> list = new List<T>();
            Node<T> previousNode = new Node<T>() ;
            Node<T> tempNode = new Node<T>();
            while(P!= null)
            {
                if(list.Contains(P.Value))
                {
                    tempNode = P;
                    //This code will delete the duplicate node
                    previousNode.Next = P.Next;
                   
                    P = tempNode.Next;
                }
                else
                {
                    list.Add(P.Value);
                    previousNode = P;
                    P = P.Next;
                }
               
            }
        }

        public void RemoveDuplicatesFromLinkedListWithoutTempBuffer()
        {
            Node<T> P = this.Head;
            Node<T> previousNode = P;
            Node<T> nodeInnerLoop = P.Next;
            Node<T> tempNode = new Node<T>();
            while (P != null)
            {
                while(nodeInnerLoop!=null)
                {
                    if (P.Value.ToString() == nodeInnerLoop.Value.ToString())
                    {
                        tempNode = nodeInnerLoop;
                        previousNode.Next = nodeInnerLoop.Next;
                        //previousNode = tempNode;
                        nodeInnerLoop = tempNode.Next;
                    }
                    else
                    {
                        previousNode = nodeInnerLoop;
                        nodeInnerLoop = nodeInnerLoop.Next;
                    }
                }
                
                P = P.Next;
                previousNode = P;
                nodeInnerLoop = P.Next;
            }
        }

        public void FindKthToLastElement(int k)
        {
            Node<T> p1 = this.Head;
            Node<T> p2 = this.Head;

            for(int i=0; i<k; i++)
            {
                //if(p1 ==null)
                    
                p1 = p1.Next;
                
            }

            while(p1!=null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            Console.WriteLine(p2.Value);
        }

        public void FindKthToLastElement1(int k)
        {
            Node<T> p = this.Head;
            int length = 0;

            while (p != null)
            {
                length++;
                p = p.Next;
            }
            p = this.Head;
            for (int i = 1; i < length - k; i++)
            {
                p = p.Next;
            }


            Console.WriteLine(p.Value);
        }

        public void Reverse()
        {
            Node<T> first = this.Head;
            Node<T> second = first.Next;

            while(second != null)
            {
                Node<T> temp = second.Next;
                second.Next = first;
                first = second;
                second = temp;
            }
            this.Head.Next = null;
            this.Head = first;

        }

    }
}
