using System;
namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x,char sym)
        {
            plist = new List<Point>();
            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}

