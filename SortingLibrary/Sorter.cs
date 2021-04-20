using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(T[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                T current = arr[i];
                int j;

                for (j = i - 1; j >= 0; j--)
                {
                    if (arr[j].CompareTo(current) > 0)
                    {
                        arr[j + 1] = arr[j];
                        continue;
                    }
                    break;
                }

                arr[j + 1] = current;
            }
        }

        public static void SelectionSort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int lowestIndex = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[lowestIndex]) < 0)
                    {
                        lowestIndex = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[lowestIndex];
                arr[lowestIndex] = temp;
            }
        }

        public static void QuickSort(T[] arr)
        {
            
        }

        public static void MergeSort(T[] arr)
        {

        }
    }
}