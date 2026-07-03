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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head is null) return head;
        ListNode next, temp=head;
        while(temp.next is not null) {
            next = temp.next;
            if(temp.val==next.val) temp.next=next.next;
            else temp=temp.next;
        }
        return head;
    }
}