using System;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 2, 10, 15, 24, 30, 36, 42, 55, 68, 90, 105, 206 };
            int target = 999;

            //int indexFound = LinearSearch.SearchLinear(items, target);
            int indexFound = BinarySearch.SearchBinary(items, target, 0, items.Length-1);

            if (indexFound != -1)
            {
                Console.WriteLine($"{target} was found at index: {indexFound}");
                Console.WriteLine($"Item at that index is: {items[indexFound]}");
            }
            else
            {
                Console.WriteLine($"{target} was not found in the array.");
            }

            Console.ReadLine();
        }
    }
}
