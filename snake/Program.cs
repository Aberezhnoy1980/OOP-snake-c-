namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new(1, 3, '*');
            p1.Draw();


            Point p2 = new(4, 5, '#');
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(5, 10, 8, '+');
            hline.Draw();

            VerticalLine vLine = new VerticalLine(4, 9, 14, '^');
            vLine.Draw();


            Console.ReadLine();
        }
    }
}