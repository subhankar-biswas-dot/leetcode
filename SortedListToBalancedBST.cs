/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    ListNode h;
    public TreeNode SortedListToBST(ListNode head) {
        ListNode dup=head;
        int n = CountNode(dup);
        h=head;
        return buildTree(n);
        
    }
    public TreeNode buildTree(int n){
        if(n<=0) return null;
        TreeNode left = buildTree(n/2);
        TreeNode temp = new TreeNode(h.val);
        temp.left=left;
        h = h.next;
        temp.right = buildTree(n-n/2-1);
        return temp;
        
    }
    public int CountNode(ListNode head){
        int count =0;
        while(head!=null){
            head=head.next;
            count++;
        }
        return count;
        
    }
}