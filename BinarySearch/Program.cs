using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int> { 1, 4, 5, 6, 9 };
            Console.WriteLine(BinarySearch(myList, 3));
            Console.WriteLine(BinarySearch(myList, -1));

        }
    }

    int BinarySearch(int list[], int item, int len)
    {

    }

}
