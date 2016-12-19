// 61. Rotate List
// https://leetcode.com/problems/rotate-list/
// by Equim on 16-12-20

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
    public ListNode RotateRight(ListNode head, int k) 
    {
        if (head == null) return null;
        
        ListNode p = head;
        int length = 1;
        while (p.next != null)
        {
            p = p.next;
            length++;
        }
        
        if (k%length == 0) return head;
        
        p.next = head;
        p = head;
        int i = 1;
        while (i < length - k%length)
        {
            p = p.next;
            i++;
        }
        head = p.next;
        p.next = null;
        
        return head;
    }
}