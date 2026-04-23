
public class LinkedList {
    private class ListNode {
        public ListNode? next;
        public int value;

        public ListNode(int value) {
            this.value = value;
            this.next = null;
        }
    }

    private ListNode? head;
    private ListNode? tail;
    private int count;

    public LinkedList() {
        this.head = null;
    }

    public int Get(int index) {
        var dummy = new ListNode(0);
        dummy.next = head;
        var cur = dummy;

        for (int i = 0; i <= index; i++) {
            // early out of bounds.
            cur = cur.next;
            if (cur is null) return -1;
        }

        return cur.value;
    }

    public void InsertHead(int val) {
        var newHead = new ListNode(val);
        newHead.next = head;
        head = newHead;
    }

    public void InsertTail(int val) {
        var newTail = new ListNode(val);
        var dummy = new ListNode(0);
        dummy.next = head;
        var cur = dummy;

        while (cur.next is not null) {
            cur = cur.next;
        }

        cur.next = newTail;
        head = dummy.next;
    }

    public bool Remove(int index) {
        var dummy = new ListNode(0);
        dummy.next = head;
        var cur = dummy;

        // go before the wanted node.
        for (int i = 0; i < index; i++) {
            cur = cur.next;
            // early out of bounds.
            if (cur is null) return false;
        }

        // late out of bounds.
        if (cur.next is null) return false;

        // cur is now the node before the target.
        // just set the current node's next to the next next
        // node to de-link the target node.
        cur.next = cur.next.next;
        head = dummy.next;
        return true;
    }

    public List<int> GetValues() {
        var values = new List<int>();
        var cur = head;
        
        while (cur is not null) {
            values.Add(cur.value);
            cur = cur.next;
        }

        return values;
    }
}