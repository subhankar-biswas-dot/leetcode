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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Traversal(root,res);
        return res;
    }
    public void Traversal(TreeNode root,IList<int> res){
        if(root==null) return;
        Traversal(root.left,res);
        res.Add(root.val);
        Traversal(root.right,res);
    }
}