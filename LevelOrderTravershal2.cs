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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
         Stack<IList<int>> st= new Stack<IList<int>>();
         IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> q=new Queue<TreeNode>();
        IList<int> curr = new List<int>();
        if(root==null) return res;
        q.Enqueue(root);
        q.Enqueue(null);
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
            }
            else{
                IList<int> dup = new List<int>(curr);
                st.Push(dup);
                curr.Clear();
                
                if(q.Any()){
                    q.Enqueue(null);
                }
            }
        }
        while(st.Any()){
            res.Add(st.Pop());
        }
        return res;
    }
}