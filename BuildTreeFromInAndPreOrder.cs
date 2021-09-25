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
    public TreeNode root;
    Dictionary<int,int> dict = new Dictionary<int,int>();
    int preIndex;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int len = inorder.Length;
        for(int i=0;i<len;i++){
            dict.Add(inorder[i],i);
        }
        preIndex=0;
        return BuildTreeUtil(preorder,inorder,0,len-1);
    }
    public TreeNode BuildTreeUtil(int [] Pre,int [] In,int start,int end){
        if(start>end) return null;
        int curr = Pre[preIndex++];
        TreeNode temp = new TreeNode(curr);
        if(start==end) return temp;
        int inIndex=dict[curr];
        temp.left=BuildTreeUtil(Pre,In,start,inIndex-1);
        temp.right=BuildTreeUtil(Pre,In,inIndex+1,end);
        return temp;
    }
    
}