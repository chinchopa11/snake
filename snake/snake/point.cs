﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point()
        {
        }

        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;      
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                x = x + offset;
            }
            else if(direction == Direction.DOWN)
            {
                x = x - offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
