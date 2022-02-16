namespace Exercise4
{
    class Program
    {
        public void EvenNumbers(int x)
        {
            Console.Write($"even numbers until {x}: ");
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" "+i);
                }
            }
        }

        public void UneavenNumbers(int x)
        {
            Console.WriteLine();
            Console.Write($"uneven numbers until {x}: ");
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(" "+i);
                }
            }
        }

        public void DivisibleBy(int x, int y)
        {
            Console.WriteLine();
            Console.Write($"Numbers divisible by {y} until {x}: ");
            for (int i = 0; i < x; i++)
            {
                if (i % y == 0)
                {
                    Console.Write(" "+i);
                }
            }
        }


        static void Main(string[] args)
        {
            var program = new Program();
            program.EvenNumbers(10);
            program.UneavenNumbers(10);
            program.DivisibleBy(100, 10);
        }
    }
}