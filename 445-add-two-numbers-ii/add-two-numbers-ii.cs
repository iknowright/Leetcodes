/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        Stack<int> stack1=new(), stack2=new();
        while(l1 is not null) { stack1.Push(l1.val); l1=l1.next; }
        while(l2 is not null) { stack2.Push(l2.val); l2=l2.next; }

        int carry=0, sum;
        ListNode head=null;
        while(stack1.Count!=0 || stack2.Count!=0 || carry==1) {
            sum = carry+(stack1.Count>0?stack1.Pop():0)+(stack2.Count>0?stack2.Pop():0);
            carry=sum/10;
            ListNode node=new(sum%10, head);
            head=node;
        }
        return head;
    }
}