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
    List<IList<int>> res=new();
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        Dfs(root, 0);
        return res;
    }

    public void Dfs(TreeNode node, int depth) {
        if(node is null) return;

        if(res.Count==depth) res.Add(new List<int>());

        if(depth%2==0) res[depth].Add(node.val);
        else res[depth].Insert(0, node.val);

        Dfs(node.left, depth+1);
        Dfs(node.right, depth+1);
    }
}