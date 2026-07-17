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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        ListNode[] res = new ListNode[k];
        int len=0; ListNode temp=head, next;
        while(temp is not null) {
            len++; temp=temp.next;
        }

        temp=head;
        for(int i=0; i<k; i++) {
            res[i]=temp;
            for(int j=0; j<len/k + (i<(len%k)?1:0)-1; j++) {
                if(temp is not null) temp=temp.next;
            }

            if(temp is not null) {
                next = temp.next;
                temp.next=null;
                temp=next;
            }
        }
        
        return res;
    }
}