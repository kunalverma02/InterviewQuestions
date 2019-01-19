using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.BinaryTree
{
    class BinarySearchTree
    {
        public BTNode root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public bool Search(char x)
        {
            return Search(x, this.root);
        }
        private bool Search(char x, BTNode p)
        {

            if (p == null)
            {
                return false;
            }


            if (p.value == x)
            {
                return true;
            }
            else if (p.value > x)
            {
                Search(x, p.lChild);
            }
            else if (p.value < x)
            {
                Search(x, p.rChild);
            }
            return false;
        }

        private bool SearchIteration(char x, BTNode node)
        {
            BTNode p = node;

            if (p == null)
            {
                return false;
            }

            while (p != null)
            {

                if (p.value == x)
                {
                    return true;
                }
                else if (p.value > x)
                {
                    p = p.lChild;
                }
                else if (p.value < x)
                {
                    p = p.rChild;
                }
            }
            return false;
        }

        private BTNode Min()
        {
            BTNode p = this.root;
            if (p == null)
            {
                return null;
            }

            while (p.lChild != null)
            {
                p = p.lChild;
            }

            return p;
        }

        private BTNode Max()
        {
            BTNode p = this.root;
            if (p == null)
            {
                return null;
            }

            while (p.rChild != null)
            {
                p = p.rChild;
            }

            return p;
        }

        public bool InsertWithIteration(BTNode node)
        {
            BTNode p = this.root;

            if (p == null)
            {
                this.root = node;
                return true;
            }

            BTNode parent = p;
            while (p != null)
            {
                parent = p;
                if (node.value == p.value)
                {
                    Console.WriteLine("Node already present in the tree.");
                    return false;
                }
                if (node.value > p.value)
                {
                    p = p.rChild;
                }
                else
                {
                    p = p.lChild;
                }
            }

            if (parent.value > node.value)
            {
                parent.lChild = node;
            }
            else
            {
                parent.rChild = node;
            }

            return true;
        }

        public bool InsertWithRecursion(BTNode node)
        {
            return InsertWithRecursion(node, this.root);
        }

        private bool InsertWithRecursion(BTNode nodeToInsert, BTNode p)
        {
            if (p == null)
            {
                p = nodeToInsert;
                return true;
            }


            if (nodeToInsert.value == p.value)
            {
                Console.WriteLine("Node already present in the tree.");
                return false;
            }
            if (nodeToInsert.value > p.value)
            {
                InsertWithRecursion(nodeToInsert, p.rChild);
            }
            else
            {
                InsertWithRecursion(nodeToInsert, p.lChild);
            }




            return true;
        }

        /*
        * Delete a Node in Binary Search tree. There can be three cases
        * Case A: Node has no child, it is a leaf node. P.LChild = null OR P.Rchild = null
        * Case B: Node has exactly one child. 
        *         If node to be deleted is left child node of it's parent node. Then, child node of deleted node will become 
        *         the left child of the parent. Similar for right child as well. If deleted node is root node then child node will become root node.
        * Case C: Node has exactly two children.
        *         Find the inorder successor of the node to be deleted.
        *         Inorder successor of a node N : leftmost node in right subtree of N.
        *         After find the inorder successor copy the data of inorder successor to the node to be deleted.
        *         Then,delete the inorder successor from the tree.
        * 
        * 
        * 
        * 
        */

        public bool Remove(char x)
        {
            BTNode p = this.root;

            BTNode parent = null;
            while (p != null)
            {
                if (x < p.value)
                {
                    parent = p;
                    p = p.lChild;
                }
                else if (x > p.value)
                {
                    parent = p;
                    p = p.rChild;
                }
                else
                {
                    break;
                }
            }

            if (p == null)
            {
                Console.WriteLine("Node is not present in the tree.");
                return false;
            }

            //Node to be deleted is root node
            if (parent == null)
            {
                if (p.lChild != null & p.rChild != null)
                {
                    BTNode p1 = p.rChild;
                    BTNode p1Parent = null;
                    while (p1.lChild != null)
                    {
                        p1Parent = p1;
                        p1 = p1.lChild;
                    }
                    p.value = p1.value;

                    p1Parent.lChild = p1.rChild;

                }
                else if (p.lChild != null && p.rChild == null)
                {
                    this.root = p.lChild;
                    p = null;
                }
                else if (p.lChild == null && p.rChild != null)
                {
                    this.root = p.rChild;
                    p = null;
                }
                else
                {
                    p = null;
                }
            }
            else
            {
                if (p.lChild != null & p.rChild != null)
                {
                    BTNode p1 = p.rChild;
                    BTNode p1Parent = null;
                    while (p1.lChild != null)
                    {
                        p1Parent = p1;
                        p1 = p1.lChild;
                    }
                    p.value = p1.value;

                    p1Parent.lChild = p1.rChild;

                }
                else if (p.lChild != null && p.rChild == null)
                {
                    if (parent.rChild == p)
                    {
                        parent.rChild = p.lChild;
                    }
                    else
                    {
                        parent.lChild = p.lChild;
                    }

                    p = null;
                }
                else if (p.lChild == null && p.rChild != null)
                {
                    if (parent.rChild == p)
                    {
                        parent.rChild = p.rChild;
                    }
                    else
                    {
                        parent.lChild = p.rChild;
                    }

                    p = null;

                }
                else
                {
                    p = null;
                }
            }

            return false;
        }


        public bool IsBST(BTNode root)
        {
            return IsBST(root, int.MinValue, int.MaxValue);
        }

        public bool IsBST(BTNode p, int min, int max)
        {

            if (p == null)
                return true;

            if (p.value < min || p.value >= max)
            {
                return false;
            }

            return IsBST(p.lChild, min, Convert.ToInt32(p.value)) && IsBST(p.rChild, Convert.ToInt32(p.value), max);

        }




        /* 
         Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

    For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.

    Example:

    Given the sorted array: [-10,-3,0,5,9],

    One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

          0
         / \
       -3   9
       /   /
     -10  5
    
         */

        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null)
                return null;

            Stack<char> a = new Stack<char>();
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBST(int[] nums, int low, int high)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;
                TreeNode root = new TreeNode(nums[mid]);
                root.left = SortedArrayToBST(nums, low, mid - 1);
                root.right = SortedArrayToBST(nums, mid + 1, high);

                return root;
            }
            return null;
        }


    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
