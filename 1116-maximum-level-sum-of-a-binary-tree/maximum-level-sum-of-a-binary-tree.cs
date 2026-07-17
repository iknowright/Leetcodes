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
    List<int> res=new();
    public int MaxLevelSum(TreeNode root) {
        Levels(root, 0);

        int index=-1, max=int.MinValue;
        for(int i=0; i<res.Count; i++) {
            if(res[i]> max) {
                max = res[i];
                index=i;
            }
        }
        return index+1;
    }

    public void Levels(TreeNode root, int level) {
        if(root is null) return;
        if(level==res.Count) res.Add(root.val);
        else res[level] += root.val;
        
        Levels(root.left, level+1);
        Levels(root.right, level+1);
    }
}