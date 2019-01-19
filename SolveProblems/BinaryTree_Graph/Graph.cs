using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.BinaryTree_Graph
{
   public class Graph
    {
       public Node root;

       public bool CheckRouteExists(Node r1, Node r2)
       {
           if (r1 == null || r2 == null)
               return false;
           
           Queue<Node> queue = new Queue<Node>();
           queue.Enqueue(r1);

           while(queue.Count >0)
           {
               Node n = queue.Dequeue();

               foreach (Node node in n.children)
               {
                   if(node.isVisited == false)
                   {
                       node.isVisited = true;
                       queue.Enqueue(node);
                       if (node == r2)
                           return true;
                   }
               }
           }
           return false;
       }


       public bool CheckRouteExists1(Node r1, Node r2)
       {
           if (r1 == null || r2 == null)
               return false;

           Queue<Node> queueL = new Queue<Node>();
           Queue<Node> queueR = new Queue<Node>();
           queueL.Enqueue(r1);
           queueR.Enqueue(r2);

           while (queueL.Count > 0)
           {
               Node n = queueL.Dequeue();

               foreach (Node node in n.children)
               {
                   if (node.isVisited == false)
                   {
                       node.isVisited = true;
                       q
                       if (node == r2)
                           return true;
                   }
               }
           }
           return false;
       }
    }
}
