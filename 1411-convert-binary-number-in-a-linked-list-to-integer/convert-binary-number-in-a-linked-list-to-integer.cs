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
    int sum=0, power=0;
    public int GetDecimalValue(ListNode head) {
        if(head is null) return 0;
        GetValue(head);
        return sum;
    }
    public int GetValue(ListNode head) {
        if(head.next is not null) power=GetValue(head.next);
        sum+=head.val*(int)Math.Pow(2, power);
        return power+1;
    }
}