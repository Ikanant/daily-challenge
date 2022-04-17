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
    // Using Recursion -------------------------------------------------------------------------------------
    // -----------------------------------------------------------------------------------------------------

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode newNode = new ListNode();
        int sum = l1.val + l2.val;

        if (sum > 9) {
            newNode.val = sum - 10;
            newNode.next = newNode.next = AddTwoNumbers(new ListNode(1), AddTwoNumbers(l1.next, l2.next));
        } else {
            newNode.val = sum;
            newNode.next = AddTwoNumbers(l1.next, l2.next);
        }

        return newNode;
    }

    // -----------------------------------------------------------------------------------------------------
    // NOT Using Recursion ---------------------------------------------------------------------------------
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



// -----------------------------------------------------------------------------------------------------
// PROBLEM DESCRIPTION ---------------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------------------

// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Example 1:

// Input: l1 = [2,4,3], l2 = [5,6,4]
// Output: [7,0,8]
// Explanation: 342 + 465 = 807.

// Example 2:

// Input: l1 = [0], l2 = [0]
// Output: [0]

// Example 3:

// Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
// Output: [8,9,9,9,0,0,0,1]

// Constraints:

//     The number of nodes in each linked list is in the range [1, 100].
//     0 <= Node.val <= 9
//     It is guaranteed that the list represents a number that does not have leading zeros.

