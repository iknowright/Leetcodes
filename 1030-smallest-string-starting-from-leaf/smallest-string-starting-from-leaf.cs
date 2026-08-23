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
    public List<string> res=new();
    public string SmallestFromLeaf(TreeNode root) {
        Dfs(root, "");
        res.Sort();
        return res[0];
    }
    public void Dfs(TreeNode node, string curr) {
        if(node is null) return;
        curr = (char)(node.val + 'a') + curr;
        if(node.left is null && node.right is null) res.Add(curr);
        else {
            Dfs(node.left, curr);
            Dfs(node.right, curr);
        }
    }
}