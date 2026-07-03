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
        List<int>left=new();
        while(fast!=null && fast.next!=null) {
            left.Add(slow.val);
            slow=slow.next;
            fast=fast.next.next;
        }
        if(fast is not null) slow=slow.next;
        
        int count=left.Count-1;
        while(slow is not null) {
            if(slow.val != left[count--]) return false;
            slow=slow.next;
        }
        return true;
    }
}