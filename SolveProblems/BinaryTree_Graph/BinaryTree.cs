using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.BinaryTree
{
    class BinaryTree
    {
        public BTNode root;

        public BinaryTree()
        {
            this.root = null;
        }

        public void PreorderTraversal()
        {
            Preorder(root);
        }
        private void Preorder(BTNode p)
        {
            if (p == null)
                return;

            Console.Write(p.value + " ");
            Preorder(p.lChild);
            Preorder(p.rChild);
        }

        public void InorderTraversal()
        {
            Inorder(root);
        }
        private void Inorder(BTNode p)
        {
            if (p == null)
                return;

            Inorder(p.lChild);
            Console.Write(p.value + " ");
            Inorder(p.rChild);
        }

        public void PostorderTraversal()
        {
            Postorder(root);
        }
        private void Postorder(BTNode p)
        {
            if (p == null)
                return;

            Postorder(p.lChild);
            Postorder(p.rChild);
            Console.Write(p.value + " "); 
        }

        public int FindHeight()
        {
            return FindHeight(this.root);
        }

        private int FindHeight(BTNode p)
        {
            if (p == null)
                return 0;
            int hLeft = FindHeight(p.lChild);
            int hRight = FindHeight(p.rChild);

            if(hLeft > hRight)
            {
                return hLeft + 1;
            }
            else
            {
                return hRight + 1;
            }
        }

        public void LevelorderTraversal()
        {
            BTNode p = this.root;

            Queue<BTNode> queue = new Queue<BTNode>();

            if (p == null)
                return;

            queue.Enqueue(p);
            BTNode node;
            while(queue.Count !=0)
            {
               node= queue.Dequeue();
               Console.WriteLine(node.value);
                if(node.lChild != null)
                { 
                    queue.Enqueue(node.lChild); 
                }
                if (node.rChild != null)
                {
                    queue.Enqueue(p.rChild);
                }
            }

        }

        public bool IsCompleteBinaryTree(BTNode root)
        {
            if (root == null)
                return true;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            bool flag = false;

            while(queue.Count >0)
            {
                BTNode node = queue.Dequeue();

                if(flag && (node.lChild != null || node.rChild !=null))
                {
                    return false;
                }

                if(node.rChild !=null && node.lChild==null)
                {
                    return false;
                }

                if(node.lChild != null)
                {
                    queue.Enqueue(node.lChild);
                }
                else
                {
                    flag = true;
                }

                if (node.rChild != null)
                {
                    queue.Enqueue(node.rChild);
                }
                else
                {
                    flag = true;
                }
            }

            return true;
        }
    }
}
