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
    int min=int.MaxValue;
    int? prev=null;
    public int GetMinimumDifference(TreeNode root) {
        InOrder(root);
        return min;
    }
    public void InOrder(TreeNode root) {
        if(root is null) return;
        InOrder(root.left);
        if(prev is not null) {
            min=Math.Min(min, root.val-prev.Value);
        }
        prev=root.val;
        InOrder(root.right);
    }
}