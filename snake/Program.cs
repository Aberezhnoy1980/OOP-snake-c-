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

            Console.WriteLine($"Point p1 = ({p1.x}, {p1.y}, {p1.sym})");
            Console.WriteLine($"Point p2 = ({p2.x}, {p2.y}, {p2.sym})");

            p1 = p2;
            Console.WriteLine($"After p1 = p2 \n p1 -> ({p1.x}, {p1.y}, {p1.sym}) \n p2 = ({p2.x}, {p2.y}, {p2.sym})");

            int x = 1;
            Func1(x);

            Func2(x);

            Func3(x);

            Move(p2, 10, 10);
            Console.WriteLine($"After p2 move \n p1 -> ({p1.x}, {p1.y}, {p1.sym}) \n p2 = ({p2.x}, {p2.y}, {p2.sym})");

            p2.x++;
            p2.y++;
            Console.WriteLine($"After p2++ \n p1 -> ({p1.x}, {p1.y}, {p1.sym}) \n p2 = ({p2.x}, {p2.y}, {p2.sym})");

            Reset(p2);
            Console.WriteLine($"After p2 reset \n p1 -> ({p1.x}, {p1.y}, {p1.sym}) \n p2 = ({p2.x}, {p2.y}, {p2.sym}))");

            Console.ReadLine();
        }

        private static void Reset(Point p)
        {
            p = new();
            Console.WriteLine($"p = ({ p.x}, { p.y}, { p.sym})");
        }

        private static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y += dy;

        }

        private static void Func1(int x)
        {
            Console.WriteLine($"Func1 x = {x}");
        }

        private static void Func2(int x)
        {
            x++;
            Console.WriteLine($"Func2 x = {x}");
        }

        private static void Func3(int x)
        {
            ++x;
            Console.WriteLine($"Func3 x = {x}");
        }
    }
}