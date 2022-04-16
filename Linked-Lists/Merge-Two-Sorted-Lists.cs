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
    // SOLUTION TWO - RECURSION
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) {
            return list2;
        }
        else if (list2 == null) {
            return list1;
        }

        if (list1.val <= list2.val) {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }

    // // SOLUTION ONE - DIRTY
    // public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    //     if (list1 == null && list2 == null) return null;
        
    //     ListNode rootNode = new ListNode();
    //     ListNode indexNode = null;
        
    //     // [1,2,4]
    //     // [1,3,4]
    //     while (list1 != null || list2 != null) {
    //         if (indexNode == null) {
    //             indexNode = rootNode;
    //         }
    //         else {
    //             indexNode.next = new ListNode();
    //             indexNode = indexNode.next;
    //         }
            
    //         if (list1 == null) {
    //             indexNode.val = list2.val;
    //             list2 = list2.next;
    //         }
    //         else if (list2 == null) {
    //             indexNode.val = list1.val;
    //             list1 = list1.next;
    //         }
    //         else {
    //             if (list1.val <= list2.val) {
    //                 indexNode.val = list1.val;
    //                 list1 = list1.next;
    //             }
    //             else {
    //                 indexNode.val = list2.val;
    //                 list2 = list2.next;
    //             }
    //         }
    //     }
        
    //     return rootNode;
    // }
}