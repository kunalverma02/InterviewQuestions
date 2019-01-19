using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProblems.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    /*
     Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

    Example:
    Input: 1->2->4, 1->3->4
    Output: 1->1->2->3->4->4
    
    */
    class MergeTwoLinkedList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            ListNode p = new ListNode(0);
            ListNode r = p;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    p.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    p.next = l2;
                    l2 = l2.next;
                }

                p = p.next;

            }

            if (l1 != null)
                p.next = l1;

            if (l2 != null)
                p.next = l2;


            return r.next;

        }
    
    }
}
