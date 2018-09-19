using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class horizontalLine : Figure
    {
        public horizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }       
        }
    }
}
