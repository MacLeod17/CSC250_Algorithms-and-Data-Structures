using System;
using System.Collections.Generic;
using System.Text;

namespace Search
{
    public class BinarySearch
    {
        public static int SearchBinary(int[] items, int target, int startIndex, int endIndex)
        {
            if (endIndex >= startIndex)
            {
                if (startIndex >= 0)
                {
                    int midIndex = (startIndex + endIndex) / 2;

                    int midValue = items[midIndex];

                    if (midValue == target)
                    {
                        return midIndex;
                    }
                    else if (midValue < target)
                    {
                        startIndex = midIndex;
                        return SearchBinary(items, target, startIndex + 1, endIndex);
                    }
                    else if (midValue > target)
                    {
                        endIndex = midIndex;
                        return SearchBinary(items, target, startIndex - 1, endIndex);
                    }
                }
            }
            
            return -1;
        }
    }
}
