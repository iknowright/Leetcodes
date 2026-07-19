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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> values;
    public TreeNode SortedListToBST(ListNode head) {
        if(head is null) return null;

        values=new List<int>();
        ListNode temp=head;
        while(temp is not null) {
            values.Add(temp.val); temp=temp.next;
        }

        return BST(0, values.Count-1);
    }
    public TreeNode BST(int left, int right) {
        if(left>right) return null;
        int mid = left + (right-left)/2;
        TreeNode root = new(values[mid]);
        root.left=BST(left, mid-1);
        root.right=BST(mid+1, right);
        return root;
    }
}