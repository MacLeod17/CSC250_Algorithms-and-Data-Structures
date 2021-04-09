using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        protected int[] bubble;

        public static void BubbleSort(T[] arr)
        {
            T myVar = arr[0];

            if (arr[0].CompareTo(arr[1]) > 0)
            {

            }
        }

        public static void InsertionSort(T[] arr)
        {
            throw new NotImplementedException();
        }

        public static void SelectionSort(T[] arr)
        {
            throw new NotImplementedException();
        }
    }
}