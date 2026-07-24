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
    public int sum=0;
    public int SumNumbers(TreeNode root) {
        Dfs(root, 0);
        return sum;
    }
    public void Dfs(TreeNode root, int curr) {
        if(root is null) return;
        curr=curr*10+root.val;
        if(root.left is null && root.right is null) sum+=curr;
        else {
            Dfs(root.left, curr); Dfs(root.right, curr);
        }
    }
}