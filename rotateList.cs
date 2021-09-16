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
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null || head.next==null) return head;
        ListNode phead=null;
        ListNode currtail=head;
        for(int i=0;i<k;i++){
            phead=currtail;
            while(phead.next.next!=null){
                phead=phead.next;
            }
            phead.next.next=currtail;
            currtail=phead.next;
            phead.next=null;
        }
        
        return currtail;
    }
    public ListNode RotateRight2(ListNode head, int k) {
        ListNode slow=head;
        ListNode fast = head;
        if (head==null) return null;
        ListNode temp=head;
        int count=0;
        while(temp!=null){
            temp=temp.next;
            count++;
        }
        k=k%count;
        
        for(int i=0;i<k;i++){
            fast=fast.next;
        }
        
        while(fast.next!=null){
            fast=fast.next;
            slow=slow.next;
        }
        //Console.WriteLine(k+" "+fast.val+" "+slow.val+" "+k);
        fast.next=head;
        ListNode result=slow.next;
        slow.next=null;
        
        return result;
    }
}
}