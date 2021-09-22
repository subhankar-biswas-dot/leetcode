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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left==right) return head;
        
        ListNode dup=head;
        ListNode dup1=new ListNode(-1);
        ListNode head1=dup1;
        ListNode ldup=new ListNode(-1);
        ListNode ldupr=ldup;
        ListNode rdup=null;
        int count =1;
        while(dup!=null){
            if(count<left){
                ldup.next=new ListNode(dup.val);
                ldup=ldup.next;
            }
            if(count>=left && count <=right){
                dup1.next=new ListNode(dup.val);
                dup1=dup1.next;
            }
            if(count == right){
                rdup=dup;
            }
            dup=dup.next;
            count++;
        }
        head1=head1.next;
        ListNode head2=head1;
        ldup.next =Reverse(head1);
        ldupr=ldupr.next;
        //dup1.next=rdup;
        if(rdup!=null){
            while(head2.next!=null){
                head2=head2.next;
            }
        }
        if(rdup!=null)
            head2.next=rdup.next;
        return ldupr;
    }
    public ListNode Reverse(ListNode head){
        ListNode current=head;
        ListNode prev=null;
        ListNode next=null;
        while(current!=null){
            next=current.next;
            current.next=prev;
            prev=current;
            current=next;
        }
        head=prev;
        
        return head;
    }
}