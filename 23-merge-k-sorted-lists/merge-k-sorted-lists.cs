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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists==null || lists.Length==0) return null;
        int interval = 1;
        while(interval < lists.Length) {
            for(int i=0; i<lists.Length-interval; i+= interval*2) {
                lists[i] = Merge(lists[i], lists[i+interval]);
            }
            interval*=2;
        }
        return lists[0];
    }

    public ListNode Merge(ListNode a, ListNode b) {
        if(a is null) return b;
        else if(b is null) return a;

        if(a.val < b.val) {
            a.next = Merge(a.next, b);
            return a;
        }
        else {
            b.next = Merge(a, b.next);
            return b;
        }
    }
}