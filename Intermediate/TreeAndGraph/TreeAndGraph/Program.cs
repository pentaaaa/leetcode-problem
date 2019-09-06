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
            foreach (int i in sol.readLevel(1, false, root))
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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
                return list;
            bool left = true;
            int level = 0;
            while (true)
            {
                IList<int> list2 = readLevel(level, left, root);
                if (list2.Count != 0)
                    list.Add(list2);
                else
                    break;
                level++;
                left = !left;
            }
            return list;
        }
        public IList<int> readLevel(int level,bool left,TreeNode root)
        {
            TreeNode node = root;
            IList<int> list = new List<int>();
            if (level == 0)
            {
                list.Add(root.val);
                return list;
            }
            int binary = (int)Math.Pow(2, level);
            for (int i = 0; i <binary; i++)
            {
                node = root;
                for (int j = 1; j <= level; j++)
                {
                    if (left?((i >> (level - j) & 1) == 0):!((i >> (level - j) & 1) == 0))
                    {
                        if (node.left == null)
                            break;
                        node = node.left;
                    }
                    else
                    {
                        if (node.right == null)
                            break;
                        node = node.right;
                    }
                    if (j == level)
                        list.Add(node.val);
                }

            }
            return list;
        }

        //根据一颗二叉树的前序遍历与中序遍历构造二叉树
        //Given preorder and inorder traversal of a tree,construct the binary tree.
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
                return null;
            TreeNode root = new TreeNode(preorder[0]);
            if (preorder.Length == 1)
                return root;
            int rootindex = 0;
            for(int i = 0; i < inorder.Length; i++) // find root index in the inorder
            {
                if (inorder[i] == preorder[0])
                {
                    rootindex = i;
                }
            }
            //build left tree
            int[] leftPreorder = new int[rootindex];
            int[] leftInorder = new int[rootindex];
            Array.Copy(preorder,1,leftPreorder,0,rootindex);
            Array.Copy(inorder, 0, leftInorder, 0, rootindex);
            root.left = BuildTree(leftPreorder, leftInorder);

            //build right tree
            int rigthSize = preorder.Length - rootindex-1;
            int[] rightPreorder = new int[rigthSize];
            int[] rightInorder = new int[rigthSize];
            Array.Copy(preorder, rootindex+1, rightPreorder, 0, rigthSize);
            Array.Copy(inorder, rootindex + 1, rightInorder, 0, rigthSize);
            root.right = BuildTree(rightPreorder, rightInorder);

            return root;
        }

        //You are given a perfect binary tree where all leaves are on the same level.and every parent has two children.
        //填充每个节点的下一个右侧节点指针
        public Node Connect(Node root)
        {
            if (root == null)
                return null;
            //queue model
            int level = 0;
            int levelCount = 1;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node Temp = queue.Dequeue();
                levelCount--;
                if (Temp.left != null)
                {
                    queue.Enqueue(Temp.left);
                    queue.Enqueue(Temp.right);
                }
                if (levelCount != 0)
                    Temp.next = queue.Peek();
                else
                {
                    level++;
                    levelCount = (int)Math.Pow(2, level);
                    Temp.next = null;
                }
            }

            //Only use constant extra space.


            return root;
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
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }
        public Node(int _val,Node _left,Node _right,Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
