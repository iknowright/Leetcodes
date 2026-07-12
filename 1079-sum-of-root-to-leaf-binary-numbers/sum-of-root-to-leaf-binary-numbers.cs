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
    int res=0;
    public int SumRootToLeaf(TreeNode root) {
        Sum(root, 0);
        return res;
    }
    public void Sum(TreeNode root, int sum) {
        if(root is null) return;
        sum=sum*2 + root.val;
        if(root.left==null && root.right==null) res+=sum;
        else {
            Sum(root.left, sum);
            Sum(root.right, sum);
        }
    }
}