using System;

namespace Linked
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //ListNode l1 = new ListNode(9);
            //ListNode l2 = new ListNode(1);
            //ListNode end = l2.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            //end = end.next = new ListNode(9);
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.next = new ListNode(9);
            ListNode solulist=
            solution.AddTwoNumbers(l1, l2);
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
    }
    public class Solution
    {
        //给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

        //如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

        //您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            double x = 0, y = 0;
            int i = 0;
            print("int max:" + (int)Math.Pow(10, 9) * 9);
            while (l1 != null)
            {
                x += Math.Pow(10, i)*l1.val;
                i++;
                l1 = l1.next;
            }
            i = 0;
            while (l2 != null)
            {
                print("10^9:" + Math.Pow(10, 9)*9);
                y += Math.Pow(10, i)*l2.val;
                i++;
                l2 = l2.next;
                print("y=" + y);
            }
            double z = x + y;
            print("x:" + x);
            print("y:" + y);
            print("z:" + z);
            print(100 % 10);
            ListNode head = new ListNode((int)(z % 10));
            z = z / 10;
            if (z < 1)
                return head;
            ListNode next = new ListNode((int)(z % 10));
            head.next = next;
            while (z/10 >=1)
            {
                //print("z/10:"+z / 10);
                z = z / 10;
                next.next = new ListNode((int)(z % 10));
                next = next.next;
            }
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
