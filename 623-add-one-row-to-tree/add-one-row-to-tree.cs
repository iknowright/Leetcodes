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
    public int resDepth, resVal;
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if(depth is 1) return new TreeNode(val, root, null);
        resDepth=depth; resVal=val;
        return Add(root, 1);
    }

    public TreeNode Add(TreeNode node, int depth) {
        if(node is null) return null;

        if(depth==resDepth-1) {
            node.left = new TreeNode(resVal, node.left, null);
            node.right = new TreeNode(resVal, null, node.right);
            return node;
        }
        node.left=Add(node.left, depth+1);
        node.right=Add(node.right, depth+1);
        return node;
    }
}