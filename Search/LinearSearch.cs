using System;
using System.Collections.Generic;
using System.Text;

namespace Search
{
    public class LinearSearch
    {
        public static int SearchLinear(int[] items, int target)
        {
            int index = -1;

            foreach (int i in items)
            {
                index++;

                if (target == i)
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
