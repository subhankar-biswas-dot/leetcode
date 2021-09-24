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
    public IList<TreeNode> GenerateTrees(int n) {
        if(n==0) return new List<TreeNode>();
        return helper(1,n);
    }
    public IList<TreeNode> helper(int m,int n){
        IList<TreeNode> res = new List<TreeNode>();
        if(m>n){
            res.Add(null);
            return res;
        }
        for(int i=m;i<=n;i++){
            IList<TreeNode> ls = helper(m,i-1);
            IList<TreeNode> rs = helper(i+1,n);
            foreach(var l in ls){
                foreach(var r in rs){
                    TreeNode curr = new TreeNode(i);
                    curr.left=l;
                    curr.right=r;
                    
                    res.Add(curr);
                }
            }
        }
        return res;
    }
}