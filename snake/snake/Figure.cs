using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Figure
    {
        protected List<point> pList;
        public void Drow()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }

    }
}
