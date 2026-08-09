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
    public int diff=0;
    public int MaxAncestorDiff(TreeNode root) {
        Dfs(root, root.val, root.val);
        return diff;
    }

    public void Dfs(TreeNode node, int min, int max) {
        if(node is null) return;
        
        diff = Math.Max(diff, Math.Max(Math.Abs(node.val-min), Math.Abs(node.val-max)));

        min = Math.Min(min, node.val);
        max = Math.Max(max, node.val);

        Dfs(node.left, min, max);
        Dfs(node.right, min, max);
    }
}