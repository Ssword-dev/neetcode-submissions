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
    public bool HasCycle(ListNode head) {
        var visited = new HashSet<ListNode>();
        var cur = head;

        while (cur is not null) {
            if (visited.Contains(cur)) {
                return true;
            }

            else {
                visited.Add(cur);
                cur = cur.next;
            }
        }

        return false;
    }
}
