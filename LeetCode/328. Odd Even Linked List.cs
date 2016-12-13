// 328. Odd Even Linked List
// https://leetcode.com/problems/odd-even-linked-list/
// by Equim on 16-12-13

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null) return null;

        var Odd = head;
        var Even = head.next;
        var EvenHead = Even;

        while (Odd.next != null && Even.next != null)
        {
            Odd.next = Odd.next.next;
            Odd = Odd.next;
            Even.next = Even.next.next;
            Even = Even.next;
        }
        Odd.next = EvenHead;

        return head;
    }
}
