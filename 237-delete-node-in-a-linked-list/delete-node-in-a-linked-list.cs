/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        ListNode prev=node;
        while(node.next is not null) {
            node.val=node.next.val;
            prev=node;
            node=node.next;
        }
        prev.next=null;
    }
}