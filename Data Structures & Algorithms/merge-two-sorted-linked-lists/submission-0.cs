#nullable enable

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode? head = null;
        ListNode? prev = null;
        var cur1 = list1;
        var cur2 = list2;

        while (cur1 is not null || cur2 is not null) {
            ListNode smallerNode;
            
            if (cur1 is null) {
                smallerNode = cur2;
                cur2 = cur2.next;
            } else if (cur2 is null) {
                smallerNode = cur1;
                cur1 = cur1.next;
            } else {
                smallerNode = cur1.val <= cur2.val ? cur1 : cur2;

                if (smallerNode == cur1) {
                    cur1 = cur1.next;
                } else {
                    cur2 = cur2.next;
                }
            }

            if (head is null) {
                head = smallerNode;
            }

            if (prev is not null) {
                prev.next = smallerNode;
            }

            prev = smallerNode;
        }

        return head!;
    }
}