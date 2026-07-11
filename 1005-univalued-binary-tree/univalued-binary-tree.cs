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
    public bool IsUnivalTree(TreeNode root) {
        if(root is null) return true;
        else if(root.left !=null && root.val != root.left.val) return false;
        else if(root.right !=null && root.val != root.right.val) return false;
        else return IsUnivalTree(root.left) && IsUnivalTree(root.right); 
    }
}