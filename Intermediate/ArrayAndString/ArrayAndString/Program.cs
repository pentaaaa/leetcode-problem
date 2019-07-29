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
            for (int x = 0; x < nums.Length-2; x++)
            {
                for(int y = x + 1; y < nums.Length - 1; y++)
                {
                    for(int z = y + 1; z < nums.Length; z++)
                    {
                        if (nums[x]+nums[y]+nums[z] == 0)
                        {
                            IList<int> mlist = new List<int>();
                            mlist.Add(nums[x]);
                            mlist.Add(nums[y]);
                            mlist.Add(nums[z]);
                            list.Add(mlist);
                            foreach (var li in list)
                            {
                                if (li.Contains(nums[x]) && li.Contains(nums[y]) && li.Contains(nums[z]))
                                {
                                    list.Remove(mlist);
                                }
                            }
                            
                        }
                    }
                }
            }
            return list;
        }
    }
}
