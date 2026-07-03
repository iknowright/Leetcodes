/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> history=new();
        while(headA is not null) {
            history.Add(headA);
            headA=headA.next;
        }
        while(headB is not null) {
            if(!history.Add(headB)) return headB;
            headB=headB.next;
        }
        return null;
    }
}