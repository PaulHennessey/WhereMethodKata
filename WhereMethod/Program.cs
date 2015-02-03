using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereMethod
{
    public class Program
    {
        public static void Main()
        {
            new Program().Run();
        }

        public void Run()
        {         
            var numbers = Enumerable.Range(0, Int32.MaxValue);

            var filteredNumbers = numbers.Filter(i => (i % 2 != 0));

            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }


    }

    public static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> numbers, Func<T, bool> del)
        {
            foreach (var number in numbers)
            {
                if (del(number))
                    yield return number;
            }
        }
    }
}

