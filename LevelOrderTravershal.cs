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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> q=new Queue<TreeNode>();
        if(root==null) return res;
        q.Enqueue(root);
        q.Enqueue(null);
        IList<int> curr = new List<int>();
        while(q.Any()){
            TreeNode temp = q.Dequeue();
            if(temp!=null){
                curr.Add(temp.val);
                if(temp.left!=null){
                    q.Enqueue(temp.left);
                }
                if(temp.right!=null){
                    q.Enqueue(temp.right);
                }
                
            }else{
                IList<int> dup = new List<int>(curr);
                res.Add(dup);
                curr.Clear();
                
                if(q.Any())
                    q.Enqueue(null);
            }
        }
        return res;
    }
}