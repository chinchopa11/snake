using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class verticalLine : Figure
    {

        public verticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<point>();
            for (int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
