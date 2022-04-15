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
//     Using Recursion ---------------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------------------
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        
        ListNode newNode = new ListNode();
        int sum = l1.val + l2.val;
        
        if (sum > 9) {
            newNode.val = sum - 10;
            newNode.next = newNode.next = AddTwoNumbers(new ListNode(1), AddTwoNumbers(l1.next, l2.next));
        }
        else {
            newNode.val = sum;
            newNode.next = AddTwoNumbers(l1.next, l2.next);
        }
        
        return newNode;
    }

// -----------------------------------------------------------------------------------------------------
//     NOT Using Recursion -----------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------------------
    
//     public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
//         ListNode rootNode = new ListNode();
//         ListNode currentNode = null;
        
//         int rem = 0;
//         int sum = 0;
//         while (l1 != null || l2 != null) {
//             if (currentNode == null) currentNode = rootNode;
//             else {
//                 currentNode.next = new ListNode();
//                 currentNode = currentNode.next;
//             }
            
//             sum = (l1?.val ?? 0) + (l2?.val ?? 0);
//             if (rem>0) {
//                 sum += rem;
//                 rem--;
//             }
            
//             if (sum > 9) {
//                 sum = sum%10;
//                 rem++;
//             }
            
//             currentNode.val = sum;
            
//             l1 = l1 == null ? l1 : l1.next;
//             l2 = l2 == null ? l2 : l2.next;
//         }
        
//         if (rem > 0) {
//             currentNode.next = new ListNode(rem);
//         }
        
//         return rootNode;
//     }
}