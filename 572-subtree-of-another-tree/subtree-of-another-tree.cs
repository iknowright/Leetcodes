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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root is null) return false;
        if(Compare(root, subRoot)) return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    public bool Compare(TreeNode root, TreeNode sub) {
        if(root==null && sub==null) return true;
        else if(root==null || sub==null) return false;
        else if(root.val != sub.val) return false;
        else return Compare(root.left, sub.left) && Compare(root.right, sub.right);
    }
}