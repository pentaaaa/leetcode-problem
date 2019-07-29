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
            string s = "III";
            Program pro = new Program();
            Console.WriteLine(pro.RomanToInt(s));
            Console.ReadKey();
        }

        //给定一个整数，判断它是否是3的幂次方
        public bool IsPowerOfThree(int n)
        {
            while (n >= 3)
            {
                Console.WriteLine(n);
                if (n == 3)
                    return true;
                n /= 3;
            }
            return false;
        }

        //罗马数字转整数
        public int RomanToInt(string s)
        {
            int I = 1;
            int V = 5;
            int X = 10;
            int L = 50;
            int C = 100;
            int D = 500;
            int M = 1000;
            int number = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1)//当不是最后一个字符时
                {
                    if (s[i] == 'I')
                    {
                        if (s[i + 1] == 'V')
                        {
                            number += (V - I);
                            i++;
                            continue;
                        }
                        if (s[i + 1] == 'X')
                        {
                            number += (X - I);
                            i++;
                            continue;
                        }
                            
                    }
                    if (s[i] == 'X')
                    {
                        if (s[i + 1] == 'L')
                        {
                            number += (L - X);
                            i++;
                            continue;
                        }
                        if (s[i + 1] == 'C')
                        {
                            number += (C - X);
                            i++;
                            continue;
                        }

                    }
                    if (s[i] == 'C')
                    {
                        if (s[i + 1] == 'D')
                        {
                            number += (D - C);
                            i++;
                            continue;
                        }
                        if (s[i + 1] == 'M')
                        {
                            number += (M - C);
                            i++;
                            continue;
                        }

                    }

                }
                
                    switch (s[i])
                    {
                        case 'I':number += I;break;
                        case 'V':number += V;break;
                        case 'X':number += X;break;
                        case 'L':number += L;break;
                        case 'C':number += C;break;
                        case 'D':number += D;break;
                        case 'M':number += M;break;
                    }
                
                
            }
            return number;
        }
    }
}
