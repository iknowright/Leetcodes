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
    public HashSet<int> res = new();
    public bool FindTarget(TreeNode root, int k) {
        return Find(root, k);
    }
    public bool Find(TreeNode node, int k) {
        if(node is null) return false;
        else if(res.Contains(k-node.val)) return true;
        else res.Add(node.val);
        return Find(node.left, k) || Find(node.right, k);
    }
}