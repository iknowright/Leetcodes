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
    public int nodes=0;
    public int GoodNodes(TreeNode root) {
        Count(root, root.val);
        return nodes;
    }
    public void Count(TreeNode root, int max) {
        if(root is null) return;
        if(root.val >=max) {
            nodes++;
            max = root.val;
        }
        Count(root.left, max);
        Count(root.right, max);
    }
}