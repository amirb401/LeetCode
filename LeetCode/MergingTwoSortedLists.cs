using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


/*
 * Easy Problem 21. Merge Two Sorted Lists -> https://leetcode.com/problems/merge-two-sorted-lists/description/
 * You are given the heads of two sorted linked lists list1 and list2.
 * Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists. 
 * Return the head of the merged linked list.
 */
namespace LeetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Init final list
            ListNode head = new ListNode(-1);
            ListNode curr = head;

            if (list1 == null) return list2;
            if (list2 == null) return list1;

            // Iterate through both lists
            while(list1 != null && list2 != null)
            {
                if (list1.val == list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                    curr = curr.next;

                    curr.next = list2;
                    list2 = list2.next;
                }
                else if (list1.val < list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else //list2 Must be smaller then list1
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr = curr.next;
            }
            if (list1 == null)
                curr.next = list2;
            else if (list2 == null)
                curr.next = list1;
            return head.next;
        }
    } // EO MergeTwoSortedLists

    public class Solution
    {
        static void Main(string[] args)
        {

            // Initialize 2 lists
            ListNode c = new ListNode(4, null);
            ListNode b = new ListNode(2, c);
            ListNode a = new ListNode(1, b);
            ListNode f = new ListNode(4, null);
            ListNode e = new ListNode(3, f);
            ListNode d = new ListNode(1, e);
            var list1 = new List<ListNode>()
            {
                a,
                b,
                c
            };
            var list2 = new List<ListNode>()
            {
                d,
                e,
                f
            };

            /* Print both lists
            foreach (ListNode node in list1)
            {
                Console.WriteLine("List 1 Node: {0}" , node.val);
            }
            foreach (ListNode node in list2)
            {
                Console.WriteLine("List 2 Node: {0}", node.val);
            }
            */

            var use = new MergeTwoSortedLists();
            //var resultHead = use.MergeTwoLists(list1.ElementAt(0), list2.ElementAt(0));
            var resultHead = use.MergeTwoLists(list1[0], list2[0]);
            Console.WriteLine("End result is: " + resultHead.val);
            while (resultHead != null)
            {
                Console.WriteLine("Value: " + resultHead.val);
                resultHead = resultHead.next;
            }
        }
    }



} // EO Namespace