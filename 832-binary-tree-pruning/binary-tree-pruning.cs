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
    public TreeNode PruneTree(TreeNode root) {
        return Prune(root)? null: root;
    }
    public bool Prune(TreeNode node) {
        if(node is null) return true;

        bool left = Prune(node.left), right = Prune(node.right);
        if(left) node.left=null;
        if(right) node.right=null;
        return left && right && node.val==0;
    }
}