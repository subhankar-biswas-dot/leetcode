**
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
       IList<IList<int>> res = new List<IList<int>>();
        if(root==null){
            return res;
            
        }
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(null);
        bool leftToRight = true;
        IList<int> curr = new List<int>();
        while(q.Any()){
            TreeNode temp=q.Dequeue();
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
                if(leftToRight){
                    IList<int> dup = new List<int>(curr);
                    res.Add(dup);
                    curr.Clear();
                }
                else{
                    Stack<int> st = new Stack<int>(curr);
                    IList<int> c_cur = new List<int>();
                    while(st.Any()){
                        c_cur.Add(st.Pop());
                    }
                    res.Add(c_cur);
                    curr.Clear();
                }
                
                if(q.Any()){
                    q.Enqueue(null);
                    leftToRight=!leftToRight;
                }
            }
            
        }
        return res;
    }
}