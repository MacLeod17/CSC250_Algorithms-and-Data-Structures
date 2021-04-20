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
            QuickSortHelper(arr, 0, arr.Length-1);
        }

        static void QuickSortHelper(T[] arr, int low, int high)
        {
            if (low < high)
            {
                T pivot = arr[high];
                int i = low - 1;

                for (int j = low; j <= high - 1; j++)
                {
                    if (arr[j].CompareTo(pivot) <= 0)
                    {
                        i++;

                        var temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;
                    }
                }

                var temp2 = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp2;

                int part = i + 1;

                QuickSortHelper(arr, low, part - 1);
                QuickSortHelper(arr, part + 1, high);
            }
        }

        public static void MergeSort(T[] arr)
        {

            MergeSortHelper(arr, 0, arr.Length-1);
        }

        static void MergeSortHelper(T[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                MergeSortHelper(arr, l, m);
                MergeSortHelper(arr, m + 1, r);

                int len1 = m - l + 1;
                int len2 = r - m;

                T[] tempLeft = new T[len1];
                T[] tempRight = new T[len2];
                int i;
                int j;

                for (i = 0; i < len1; ++i)
                {
                    tempLeft[i] = arr[l + i];
                }
                for (j = 0; j < len2; ++j)
                {
                    tempRight[j] = arr[m + 1 + j];
                }

                i = 0;
                j = 0;
                int k = l;

                while (i < len1 && j < len2)
                {
                    if (tempLeft[i].CompareTo(tempRight[j]) <= 0)
                    {
                        arr[k] = tempLeft[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = tempRight[j];
                        j++;
                    }
                    k++;
                }

                while (i < len1)
                {
                    arr[k] = tempLeft[i];
                    i++;
                    k++;
                }

                while (j < len2)
                {
                    arr[k] = tempRight[j];
                    j++;
                    k++;
                }
            }
        }
    }
}