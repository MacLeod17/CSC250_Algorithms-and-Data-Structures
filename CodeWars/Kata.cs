using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
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
