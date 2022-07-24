using System;
namespace snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var f in pList)
            {
                if (figure.IsHit(f))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (Point p in pList)
            {
                if(p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}

