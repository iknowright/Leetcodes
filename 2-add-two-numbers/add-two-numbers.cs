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
        int carry=0, sum;
        ListNode dummy = new ListNode(0);
        ListNode prev=dummy;
        while(l1!=null || l2!=null || carry==1) {
            sum = carry;
            if(l1!=null) {
                sum+=l1.val;
                l1=l1.next;
            }
            if(l2!=null) {
                sum+=l2.val;
                l2=l2.next;
            }
            carry=sum/10;
            prev.next=new ListNode(sum%10);
            prev=prev.next;
        }
        return dummy.next;
    }
}