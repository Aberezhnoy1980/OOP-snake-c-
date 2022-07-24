namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.SetBufferSize(Walls.GetMapWidth(), Walls.GetMapHeight());
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }

            Walls walls = new Walls();
            walls.Draw();

            // point rendering
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(Walls.GetMapWidth(), Walls.GetMapHeight(), '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlerKey(key.Key);
                }
                Thread.Sleep(200);
                snake.Move();
            }
        }
    }
}