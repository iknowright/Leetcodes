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
    public bool IsSymmetric(TreeNode root) {
        return IsSameRoots(root.left, root.right);
    }
    public bool IsSameRoots(TreeNode root1, TreeNode root2) {
        if(root1 is null && root2 is null) return true;
        else if(root1 is null || root2 is null) return false;
        else if(root1.val != root2.val) return false;
        else return IsSameRoots(root1.right, root2.left) && IsSameRoots(root1.left, root2.right);
    }
}