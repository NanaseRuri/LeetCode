using System;
public class AddTwoNumbers_2
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public void Test()
    {
        ListNode l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);

        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);

        ListNode result = AddTwoNumbers(l1, l2);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }


    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int addedResult=l1.val+l2.val;
        int result=addedResult%10;
        int carry=addedResult/10;

        ListNode start=new ListNode(result);
        ListNode variantNode=start;
        l1=l1.next;
        l2=l2.next;
        
        while(l1!=null&&l2!=null){
            addedResult=l1.val+l2.val+carry;
            carry=addedResult/10;
            result=addedResult%10;
            
            variantNode.next=new ListNode(result);
            
            variantNode=variantNode.next;
            l1=l1.next;
            l2=l2.next;
        }
        while(l1!=null&&l2==null){
            addedResult=l1.val+carry;
            carry=addedResult/10;
            result=addedResult%10;
            
            variantNode.next=new ListNode(result);
            
            variantNode=variantNode.next;
            l1=l1.next;
        }
        while(l1==null&&l2!=null){ 
            addedResult=l2.val+carry;
            carry=addedResult/10;
            result=addedResult%10;
            
            variantNode.next=new ListNode(result);
            
            variantNode=variantNode.next;
            l2=l2.next;
        }

        if(carry>0){
            variantNode.next=new ListNode(1);
        }

        return start;
    }
}