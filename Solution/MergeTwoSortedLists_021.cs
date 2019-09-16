using System;
namespace LeetCode.Solution
{
    public class MergeTwoSortedLists_021
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode head = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    head.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    head.next = l2;
                    l2 = l2.next;
                }
                head = head.next;
            }
            head.next = l1 == null ? l2 : l1;

            return dummy.next;
        }

        public void Test()
        {
            ListNode[] listNodes1 = new[]{
                new ListNode(1),
                new ListNode(2)                ,
                new ListNode(4)
            };

            ListNode[] listNodes2 = new[]{
                new ListNode(1),
                new ListNode(3),
                new ListNode(4)
            };

            ListNode l1 = listNodes1[0];
            ListNode temp1 = l1;
            for (int i = 1; i < listNodes1.Length; i++)
            {
                temp1.next = listNodes1[i];
                temp1 = temp1.next;
            }

            ListNode l2 = listNodes2[0];
            ListNode temp2 = l2;
            for (int i = 1; i < listNodes2.Length; i++)
            {
                temp2.next = listNodes2[i];
                temp2 = temp2.next;
            }
            ListNode result = MergeTwoLists(l1, l2);

            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    }
}