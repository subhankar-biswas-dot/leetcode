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
    int index=0;
    public void RecoverTree(TreeNode root) {
        int n = CountNode(root);
        int [] array = new int[n];
        StoreInOrder(root,array);
        Array.Sort(array);
        index=0;
        arrayToBST(root,array);
        foreach(var k in array){
            Console.Write(k+" ");
        }
        
        
    }
    public int CountNode(TreeNode root){
        if(root==null) return 0;
        return CountNode(root.left)+CountNode(root.right)+1;
        
    }
    public void StoreInOrder(TreeNode root,int [] array){
        if(root==null) return;
        StoreInOrder(root.left,array);
        array[index]=root.val;
        index++;
        StoreInOrder(root.right,array);
    }
    public void arrayToBST(TreeNode root,int [] arr){
        if(root==null) return;
        arrayToBST(root.left,arr);
        root.val = arr[index];
        index++;
        arrayToBST(root.right,arr);
    }
    
}