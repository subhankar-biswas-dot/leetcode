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
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode dup1 = new ListNode(-1);
        ListNode dup2 = new ListNode(-1);
        ListNode head2=dup2;
        ListNode head1=dup1;
        
        ListNode dup=head;
        
        
        while(dup!=null){
            if(dup.val<x){
                
                dup1.next = new ListNode(dup.val);
                dup1=dup1.next;
            }
            else{
                ListNode temp = new ListNode(dup.val);
                dup2.next=temp;
                dup2=dup2.next;
                
            }
            dup=dup.next;
        }
        head1=head1.next;
        head2=head2.next;
        if(head1==null) return head2;
        dup1.next=head2;
        return head1;
    }
}