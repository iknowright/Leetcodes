/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        HashSet<ListNode> history=new();
        while(head!=null) {
            if(!history.Add(head)) return head;
            head=head.next;
        }
        return null;
    }
}