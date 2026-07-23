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
    int max=0, sum=0;
    public int DeepestLeavesSum(TreeNode root) {
        Dfs(root, 0);
        return sum;
    }
    public void Dfs(TreeNode root, int level) {
        if(root is null) return;
        if(level>max) {
            max=level;
            sum=root.val;
        }
        else if(level==max) sum+=root.val;

        Dfs(root.left, level+1);
        Dfs(root.right, level+1);
    }
}