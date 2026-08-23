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
public class FindElements {
    public HashSet<int> nodes;
    public FindElements(TreeNode root) {
        nodes = new HashSet<int>();
        Create(root, 0);
    }
    
    public bool Find(int target) {
        return nodes.Contains(target);
    }

    public void Create(TreeNode node, int val) {
        if(node is null) return;
        node.val = val; nodes.Add(val);
        
        Create(node.left, 2*val +1);
        Create(node.right, 2*val +2);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */