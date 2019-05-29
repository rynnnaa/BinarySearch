using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myList = new List<int> { 1, 4, 5, 6, 9 };
            Console.WriteLine(BinarySearch(myList, 3));
            Console.WriteLine(BinarySearch(myList, -1));

        }

        private static int? BinarySearch(IList<int> list, int item)
        {
            var low = 0;
            var high = list.Count() - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = list[mid];
                if (guess == item) return mid;
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }

            return null;
        }
    }
}
