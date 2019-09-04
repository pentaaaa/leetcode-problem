using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            Solution sol = new Solution();
            foreach (int i in sol.readLevel(2, true, root))
            {
                print(i);
            }
            Console.ReadKey();
        }
        

        //api
        public static void print(int i)
        {
            Console.WriteLine(i);
        }
        public static void print(string s)
        {
            Console.WriteLine(s);
        }
    }
    public class Solution
    {
        //Given a binary tree,return the inorder traversal of its nodes values.
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;
            if (root.left != null)
            {
                foreach (int i in InorderTraversal(root.left))
                {
                    list.Add(i);
                }
            }
            list.Add(root.val);
            if (root.right != null)
            {
                foreach (int i in InorderTraversal(root.right))
                {
                    list.Add(i);
                }
            }
            return list;
        }


        //Given a binary tree, return the zigzag level order reaversal of its nodes' values.
        //public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        //{
        //    int level = 0;
        //}
        public IList<int> readLevel(int level,bool left,TreeNode root)
        {
            TreeNode node = root;
            IList<int> list = new List<int>();
            int binary = (int)Math.Pow(2, level);
            for (int i = 0; i <binary; i++)
            {
                print("i" + i);
                node = root;
                for (int j = 1; j <= level; j++)
                {
                    if (((i >> (level - j) & 1) == 0) && left)
                    {
                        if (root.left == null)
                            break;
                        root = root.left;
                    }
                    else
                    {
                        if (root.right == null)
                            break;
                        root = root.right;
                    }
                    if (j == level)
                        list.Add(root.val);
                }

            }
            return list;
        }


        //api
        public static void print(int i)
        {
            Console.WriteLine(i);
        }
        public static void print(string s)
        {
            Console.WriteLine(s);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
