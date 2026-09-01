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
    List<int> values=new();
    public TreeNode IncreasingBST(TreeNode root) {
        Inorder(root);

        if(values.Count==0) return null;
        TreeNode head = new TreeNode(values[0]), temp=head;
        for(int i=1; i<values.Count; i++) {
            temp.left = null;
            temp.right = new TreeNode(values[i]);
            temp = temp.right;
        }

        return head;
    }

    public void Inorder(TreeNode node) {
        if(node is null) return;
        Inorder(node.left);
        values.Add(node.val);
        Inorder(node.right);
    }
}