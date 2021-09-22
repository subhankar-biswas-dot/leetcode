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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode current = head;
        ListNode next_next;
        ListNode last_single=null;
        if(head == null) return null;
        
        while(current!=null && current.next !=null){
            if(current.val == current.next.val){
                while(current!=null && current.next!=null && current.val==current.next.val){
                    current=current.next;
                }
                
                current=current.next;
                if(last_single==null){
                    head=current;
                }else{
                    last_single.next=current;
                }
              
            }
            else{
                last_single=current;
                current=current.next;
            }
        }
        return head;
    }
}