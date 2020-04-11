using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode30Days
{
    public static class Day3
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int nxt = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    arr[nxt] = arr[i];
                    nxt++;
                }

            }
            for(int k = nxt;  k < arr.Length; k++)
            {
                arr[k] = 0;
            }
            return arr;
        }
    }
}
