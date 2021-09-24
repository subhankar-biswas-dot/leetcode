public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root==null) return true;
        if(root.left!=null && FindMax(root.left).val >=root.val) return false;
        if(root.right!=null && FindMin(root.right).val<=root.val) return false;
        if(!IsValidBST(root.left) || !IsValidBST(root.right)) return false;
        return true;
    }
    public TreeNode FindMax(TreeNode root){
        
        while(root.right!=null){
            root=root.right;
        }
        return root;
    }
    public TreeNode FindMin(TreeNode root){
        
        while(root.left!=null){
            root=root.left;
        }
        return root;
    }
}