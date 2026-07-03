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
    public bool IsPalindrome(ListNode head) {
        if(head is null) return true;
        ListNode slow=head, fast=head;
        List<int>left=new(), right=new();
        while(fast!=null && fast.next!=null) {
            left.Add(slow.val);
            slow=slow.next;
            fast=fast.next.next;
        }
        if(fast is not null) slow=slow.next;
        while(slow is not null) {
            right.Add(slow.val);
            slow=slow.next;
        }
        return left.AsEnumerable().Reverse().SequenceEqual(right);
    }
}