using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereMethod.Solution
{
    class Solution
    {
        public static void Main2()
        {
            var nums = Enumerable.Range(0, Int32.MaxValue);

            IEnumerable<int> filteredNums = nums.Filter(i => i % 2 == 0);

            foreach (int i in filteredNums)
            {
                Console.WriteLine(i);
            }

        }
    }

    public static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> nums, Func<T, bool> del)
        {
            foreach (T i in nums)
            {
                if (del(i))
                {
                    yield return i;
                }
            }
        }
    }
}
