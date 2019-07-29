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
            Console.WriteLine(solution.reverseBits(43261596));
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
        /// <summary>
        /// 计算两个整数的汉明距离
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistance(int x, int y)
        {
            int z = x ^ y;
            int num = 0;
            while (z > 0)
            {
                num++;
                z = z & (z - 1);
            }
            return num;
        }

        /// <summary>
        /// 颠倒二进制位
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public uint reverseBits(uint n)
        {
            uint bits = 0;
            for(int i = 0; i < 32; i++)
            {
                bits += n % 2 * (uint)Math.Pow(2, 31 - i);
                n = n >> 1;
            }
            return bits;
        }
    }
}
