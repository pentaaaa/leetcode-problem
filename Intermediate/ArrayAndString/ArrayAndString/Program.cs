using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string max = solution.LongestPalindrome("babad");
            print(max + "--max length:" + max.Length);
            Console.ReadKey();
        }


        //api
        static void print(int i)
        {
            Console.WriteLine(i);
        }
        static void print(string str)
        {
            Console.WriteLine(str);
        }
        static void print(bool b)
        {
            if (b)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
    public class Solution
    {
        /// <summary>
        /// 三数之和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            
            Array.Sort(nums);
            
            return list;
        }
        bool sameArr(int[] arr1, int[] arr2)
        {
            //Array.Sort(arr1,arr2);
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
            
        }

        //给定一个 m x n 的矩阵，如果一个元素为 0，则将其所在行和列的所有元素都设为 0。请使用原地算法。
        public void SetZeroes(int[][] matrix)
        {
            List<int> xlist = new List<int>();
            List<int> ylist = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        xlist.Add(i);
                        ylist.Add(j);
                    }
                }
            }
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[0].Length; j++)
                {
                    if (xlist.Contains(i) || ylist.Contains(j))
                        matrix[i][j] = 0;
                }
            }
        }

        //给定一个字符串数组，将字母异位词组合在一起。字母异位词指字母相同，但排列不同的字符串
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();
            string[] strs2 = new string[strs.Length];
            for(int i = 0; i < strs.Length; i++)
            {
                char[] chars = strs[i].ToArray();
                Array.Sort(chars);
                strs2[i] = new string(chars);
            }
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for(int i = 0; i < strs.Length; i++)
            {
                if(dic.ContainsKey(strs2[i]))
                {
                    dic[strs2[i]].Add(strs[i]);
                }
                else
                {
                    List<string> mlist = new List<string>();
                    mlist.Add(strs[i]);
                    dic.Add(strs2[i], mlist);
                    list.Add(mlist);
                }
            }
            return list;
        }
        public bool isSameStr(Dictionary<char,int> dic1,Dictionary<char,int> dic2)
        {
            if (dic1.Count != dic2.Count)
                return false;
            foreach(var kvp in dic1)
            {
                if (!dic2.ContainsKey(kvp.Key))
                    return false;
                if (dic2[kvp.Key] != kvp.Value)
                    return false;
            }
            return true;
        }

        //给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            HashSet<char> hash = new HashSet<char>();
            List<char> list = new List<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (!hash.Contains(s[i])) //如果哈希里面不存在
                {
                    hash.Add(s[i]);
                    list.Add(s[i]);
                }
                else            //否则已经存在了
                {
                    if (list.Count > max)
                        max = list.Count;
                    while (list[0] != s[i])
                    {
                        list.Remove(list[0]);
                        hash.Remove(list[0]);
                    }
                    list.Remove(s[i]);
                    list.Add(s[i]);
                }
            }
            if (list.Count > max)
                return list.Count;
            return max;
        }

        //给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
        public string LongestPalindrome(string s)
        {
            string max = "";
            if (s.Length == 1)
                return s;
            if (s.Length == 2 && s[0] != s[1])
            {
                return s[0].ToString();
            }
            for(int i = 0; i < s.Length-1; i++)
            {
                if ((s[i] == s[i + 1])||(i>0&&(s[i - 1] == s[i + 1])))//偶数回文开始验证
                {
                    int x = i, y = i + 1;
                    if(i > 0 && (s[i - 1] == s[i + 1]))
                    {
                        x = i - 1;
                    }
                    while (x > -1 && y < s.Length)
                    {
                        if (s[x] != s[y])
                            break;
                        x--;y++;
                    }
                    x++;y--;
                    if ((y - x + 1) > max.Length)
                    {
                        print("a new max string:");
                        char[] c = new char[y - x + 1];
                        for (int j = 0; j < c.Length; j++)
                        {
                            c[j] = s[x + j];
                            print(j+"word:"+c[i]);
                        }
                        max = new string(c);
                        print("new string:" + max);
                    }
                }
            }
            return max;
        }




        //自定义api
        void print(int i)
        {
            Console.WriteLine(i);
        }
        void print(string str)
        {
            Console.WriteLine(str);
        }
        void print(char cha)
        {
            Console.WriteLine(cha);
        }
    }
}
