using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.HammingWeight(5));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        /// <summary>
        /// 返回整数二进制表示种的1的个数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight(uint n)
        {
            int num = 0;
            while (n > 0)
            {
                num += (int)(n % 2);
                n = n >> 1;
            }
            return num;
        }
    }
}
