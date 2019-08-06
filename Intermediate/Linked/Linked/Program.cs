using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            solution.AddTwoNumbers(l1, l2);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        //给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

        //如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

        //您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int x = 0, y = 0;
            int i = 0;
            while (l1 != null)
            {
                x += (int)Math.Pow(10, i)*l1.val;
                i++;
                l1 = l1.next;
            }
            i = 0;
            while (l2 != null)
            {
                y += (int)Math.Pow(10, i)*l2.val;
                i++;
                l2 = l2.next;
            }
            int z = x + y;
            print("x:" + x);
            print("y:" + y);
            print("z:" + z);
            ListNode head = new ListNode(z % 10);
            z = z / 10;
            if (z == 0)
                return head;
            ListNode next = new ListNode(z % 10);
            head.next = next;
            while (z/10 != 0)
            {
                z = z / 10;
                next.next = new ListNode(z % 10);
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
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
