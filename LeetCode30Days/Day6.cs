using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode30Days
{
    public static class Day6
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> vs = new List<IList<string>>();

            var lookup = strs.ToLookup(key =>
            {
                var array = key.ToCharArray();
                Array.Sort(array);
                return new string(array);
            });
            return lookup.Select(grouping => (IList<string>)grouping.ToList()).ToList();




            //return result;
        }
    }
}
