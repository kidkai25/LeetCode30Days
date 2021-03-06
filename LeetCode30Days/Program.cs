﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode30Days
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strs = new[] {"eat", "tea", "tan", "ate", "nat", "bat" };
            var lookup = strs.ToLookup(key =>
            {
                var array = key.ToCharArray();
                Array.Sort(array);
                return new string(array);
            });
            var x = lookup.Select(grouping => (IList<string>)grouping.ToList()).ToList();
            Console.WriteLine("Hello World!");
        }
    }
}
