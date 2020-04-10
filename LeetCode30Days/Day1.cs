using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode30Days
{
    static class Day1
    {
        public static int SingleNumber(int[] nums)
        {
            var x = nums.GroupBy(x => x)
                        .Where(g => g.Count() == 1)
                        .First();


            return x.Key;
        }
    }
}
