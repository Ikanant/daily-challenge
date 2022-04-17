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
    // -----------------------------------------------------------------------------------------------------
    // Solution ONE - DIRTY  -------------------------------------------------------------------------------------
    // -----------------------------------------------------------------------------------------------------
    public ListNode ReverseList(ListNode head) {
        if (head == null) return null;

        ListNode index = head;
        ListNode newRoot = head;
        ListNode prevNode = null;

        while (head.next != null) {
            if (index.next.next == null) {
                newRoot = index.next;
                newRoot.next = index;
                index = head;
            } else if (index.next.next == index) {
                index.next = prevNode;
                index = head;
                prevNode = null;
            } else {
                prevNode = index;
                index = index.next;
            }
        }

        return newRoot;
    }
}