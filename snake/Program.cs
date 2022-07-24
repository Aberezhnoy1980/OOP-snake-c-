namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new Exception();
            try
            {
                Console.SetBufferSize(80, 25);
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }

            //frame rendering
            HorizontalLine upLine = new HorizontalLine(0, 9, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 9, 9, '+');
            VerticalLine leftLine = new VerticalLine(0, 9, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 9, 9, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // point rendering
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
        }
    }
}