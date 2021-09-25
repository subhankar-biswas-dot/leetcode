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
    //TreeNode temp = new TreeNode(-1);
    public void Flatten(TreeNode root) {
        if(root==null) return;
        if(root.left==null && root.right ==null) return;
        if(root.left!=null){
            Flatten(root.left);
            TreeNode temp = root.right;
            root.right=root.left;
            root.left=null;
            TreeNode curr =root.right;
            while(curr.right!=null){
                curr=curr.right;
            }
            curr.right=temp;
            
        }
        Flatten(root.right);
        
    }
}