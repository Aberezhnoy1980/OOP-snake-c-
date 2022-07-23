namespace snake
{
    class Program
    {
        static void Main( string[] args )
        {

            Point p1 = new(1, 3, '*'); // new Point();
            p1.Draw();


            Point p2 = new(4, 5, '#');
            p2.Draw();

            Console.ReadLine();
        }
    }
}