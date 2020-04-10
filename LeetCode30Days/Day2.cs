using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode30Days
{
    static class Day2
    {
        public static bool IsHappy(int n)
        {
            //Take a HashSet 
            HashSet<int> vs = new HashSet<int>();

           while(n != 1) // loop continues
            {
                int current = n;
                int sum = 0;
                while(current != 0)
                {
                    sum += (current % 10) * (current % 10);
                    current /= 10;
                }

                if (vs.Contains(sum))
                    return false;
                vs.Add(sum);
                n = sum;
            }
           return  true;
        }
    }
}
