using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public static int[,] FloodFill(int[,] array, int y, int x, int newValue, int oldValue = int.MinValue)
        {
            if (oldValue == int.MinValue) oldValue = array[y, x];

            int lenY = array.GetLength(0) - 1;
            int lenX = array.GetLength(1) - 1;

            if (array[y, x] != oldValue || array[y, x] == newValue) return array;

            array[y, x] = newValue;

            if (y < lenY) array = FloodFill(array, y + 1, x, newValue, oldValue);
            if (y > 0) array = FloodFill(array, y - 1, x, newValue, oldValue);
            if (x < lenX) array = FloodFill(array, y, x + 1, newValue, oldValue);
            if (x > 0) array = FloodFill(array, y, x - 1, newValue, oldValue);

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
