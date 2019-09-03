﻿using System;

namespace Linked
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);
            ListNode solulist =
            solution.OddEvenList(node);
            while (solulist != null)
            {
                print(solulist.val);
                solulist = solulist.next;
            }
            Console.ReadKey();
        }
        public static void print(int i)
        {
            Console.WriteLine(i);
        }
        public static void print(double d)
        {
            Console.WriteLine(d);
        }
        public static void print(string s)
        {
            Console.WriteLine(s);
        }
        public static void print(bool b)
        {
            if (b)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
    public class Solution
    {
        //给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

        //如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

        //您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int add = 0;
            ListNode node = null;
            ListNode head = null;
            while (l1 != null || l2 != null)
            {
                int x = l1 == null ? 0 : l1.val;
                int y = l2 == null ? 0 : l2.val;
                int z = x + y + add;
                if (z > 9)
                {
                    z -= 10;
                    add = 1;
                }
                else
                    add = 0;
                if (head == null)
                {
                    head = new ListNode(z);
                    node = head;
                }
                else
                {
                    node.next = new ListNode(z);
                    node = node.next;
                }
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            if (add == 1)
                node.next = new ListNode(1);
            return head;
        }

        //给定一个单链表，把所有的奇数节点和偶数节点分别排在一起。请注意，这里的奇数节点和偶数节点指的是节点编号的奇偶性，而不是节点的值的奇偶性。
        //请尝试使用原地算法完成。你的算法的空间复杂度应为 O(1)，时间复杂度应为 O(nodes)，nodes 为节点总数。
        public ListNode OddEvenList(ListNode head)
        {
            bool odd = true;
            ListNode node = head;
            ListNode node2 = null;
            ListNode head2 = null;
            while (node != null)
            {
                print("while:" + node.val);
                if (odd&&node.next!=null&&node.next.next!=null)
                {
                    node.next = node.next.next;
                }
                else if(!odd)
                {
                    node.next = null;
                    print("even");
                    if (head2 == null)
                    {
                        head2 = node;print(head2.val);
                        node2 = head2;
                    }
                    else
                    {
                        node2.next = node;
                        node2 = node2.next;
                    }
                }
                if (node.next == null)
                    break;
                node = node.next;
                odd = !odd;
            }
            //node.next = head2;
            return head;
        }




        //api
        public static void print(int i)
        {
            Console.WriteLine(i);
        }
        public static void print(string str)
        {
            Console.WriteLine(str);
        }
        public static void print(double d)
        {
            Console.WriteLine(d);
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
