using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Grid
    {
        public static int NumberOfRectangles(int w, int h)
        {
            return (h*(h+1)*w*(w+1))/4;
        }
    }
}
