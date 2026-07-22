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
    public ListNode RotateRight(ListNode head, int k) {
        if(k==0 || head is null || head.next is null) return head;

        int length=1;
        ListNode tail=head;
        while(tail.next is not null) {
            tail=tail.next;
            length++;
        }

        tail.next=head;
        k = k%length;
        tail=head;
        for(int i=1; i<length-k; i++) tail=tail.next;

        head=tail.next;
        tail.next=null;
        return head;
    }
}