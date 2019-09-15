using System;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode.Solution
{
    public class RemoveNthNodeFromEndOfList_019
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode first = dummy;
            ListNode second = dummy;
            for (int i = 0; i < n; i++)
            {
                first = first.next;
            }

            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }

            ListNode temp = second.next;
            second.next = null;
            second.next = temp.next;

            return dummy.next;
        }

        // v1.0，使用一个链表存放节点，忽略了添加节点至表的开销
        // public ListNode RemoveNthFromEnd(ListNode head, int n)
        // {
        //     List<ListNode> list = new List<ListNode>();

        //     ListNode node = head;
        //     list.Add(head);
        //     while (node.next != null)
        //     {
        //         list.Add(node.next);
        //         node = node.next;
        //     }

        //     if (n == list.Count)
        //     {
        //         return head.next;
        //     }
        //     else if (n == 1)
        //     {
        //         list[list.Count - 2].next = null;
        //         return head;
        //     }
        //     else
        //     {
        //         list[list.Count - n].next = null;
        //         list[list.Count - n - 1].next = list[list.Count - n + 1];
        //         return head;
        //     }
        // }

        public void Test()
        {
            ListNode[] nodes = new ListNode[5];
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new ListNode(i);
            }

            for (int i = 0; i < nodes.Length - 1; i++)
            {
                nodes[i].next = nodes[i + 1];
            }

            ListNode node = RemoveNthFromEnd(nodes[0], 3);

            while (node.next != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
            Console.WriteLine(node.val);
        }
    }
}