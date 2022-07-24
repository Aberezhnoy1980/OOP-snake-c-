namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);

            // frame rendering
            //HorizontalLine upLine = new HorizontalLine(0, 9, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 9, 9, '+');
            //VerticalLine leftLine = new VerticalLine(0, 9, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 9, 9, '+');
            //upLine.Draw();
            //downLine.Draw();
            //leftLine.Draw();
            //rightLine.Draw();

            // point rendering
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
        }
    }
}