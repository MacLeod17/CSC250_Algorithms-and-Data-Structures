using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Grid
    {
        public static int NumberOfRectangles(int w, int h)
        {
            var tempX = 0;
            var tempY = 0;

            for (int i = 1; i <= w; i++)
            {
                tempX += i;
            }

            for (int i = 1; i <= h; i++)
            {
                tempY += i;
            }

            return tempX * tempY;

            //return (h*(h+1)*w*(w+1))/4;
        }
    }
}
