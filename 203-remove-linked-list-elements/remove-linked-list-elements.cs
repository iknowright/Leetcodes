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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head is null) return head;
        ListNode temp=new(0), next;
        temp.next=head; head=temp;
        while(temp is not null) {
            next=temp.next;
            if(next is not null && next.val==val) temp.next=next.next;
            else temp=temp.next;
        }
        return head.next;
    }
}