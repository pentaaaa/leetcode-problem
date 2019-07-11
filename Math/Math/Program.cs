using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //给定一个整数，判断它是否是3的幂次方
        public bool IsPowerOfThree(int n)
        {
            while (n >= 3)
            {
                if (n == 3)
                    return true;
                n /= 3;
            }
            return false;
        }
    }
}
