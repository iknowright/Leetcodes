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
    int res=0, curr, count;
    public int AverageOfSubtree(TreeNode root) {
        PostOrder(root);
        return res;
    }
    public (int sum, int count) PostOrder(TreeNode node) {
        if(node is null) return (0, 0);
        var left = PostOrder(node.left);
        var right = PostOrder(node.right);
        curr = left.sum + right.sum + node.val;
        count = left.count + right.count + 1;
        if(curr/count == node.val) res++;
        return (curr, count);
    } 
}