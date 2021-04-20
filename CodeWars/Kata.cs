using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
        {
            int oldValue = array[y, x];

            int lenY = array.GetLength(0) - 1;
            int lenX = array.GetLength(1) - 1;

            return FloodFillUtil(array, y, x, newValue, oldValue, lenY, lenX);
        }

        public static int[,] FloodFillUtil(int[,] array, int y, int x, int newValue, int oldValue, int lenY, int lenX)
        {
            if (array[y, x] == oldValue)
            {
                array[y, x] = newValue;
                if (y < lenY) array = FloodFillUtil(array, y + 1, x, newValue, oldValue, lenY, lenX);
                else if (y > 0) array = FloodFillUtil(array, y - 1, x, newValue, oldValue, lenY, lenX);
                if (x < lenX) array = FloodFillUtil(array, y, x + 1, newValue, oldValue, lenY, lenX);
                else if (x > 0) array = FloodFillUtil(array, y, x - 1, newValue, oldValue, lenY, lenX);
            }

            return array;
        }

        public static bool IsValidWalk(string[] walk)
        {
            int n = 0;
            int s = 0;
            int e = 0;
            int w = 0;

            foreach (var dir in walk)
            {
                if (dir.Equals("n"))
                {
                    n++;
                }
                else if (dir.Equals("s"))
                {
                    s++;
                }
                else if (dir.Equals("e"))
                {
                    e++;
                }
                else if (dir.Equals("w"))
                {
                    w++;
                }
            }

            if (walk.Length == 10)
            {
                if (n == s && w == e)
                {
                    return true;
                }
            }

            return false;
        }
        
    }
}
