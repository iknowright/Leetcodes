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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        if(head.next.next is null) return [-1, -1];

        ListNode prev=head, curr=head.next, next;
        int val=1, first=-1, last=-1, min=int.MaxValue;
        bool minima=false, maxima=false;
        while(curr.next != null) {
            next = curr.next;
            minima = curr.val<prev.val && curr.val<next.val;
            maxima = curr.val>prev.val && curr.val>next.val;
            if(minima || maxima) {
                if(first==-1) {
                    first=val; last=val;
                }
                else {
                    min = Math.Min(min, val-last);
                    last = val;
                }
            }
            prev = curr;
            curr = next;
            val++;
        }

        if(first==-1 || first==last) return [-1, -1];
        return [min, last-first];
    }
}