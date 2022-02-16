namespace Exercise10
{
    class Program
    {
        public int BiggestDifference(int[] arrayOfInts)
        {
            if (arrayOfInts.Length <= 1)
            {
                Console.WriteLine("the size of the array of integers is too small");
                return 0;
            }
            int max = arrayOfInts.Max();
            int min = arrayOfInts.Min();

            return max - min;
        }
        
        public static void Main(string[] args)
        {
            Program p1 = new();
            int[] arrayOfInts = new[] {10, 3, 5, 6};
            Console.WriteLine(p1.BiggestDifference(arrayOfInts));
        }
    }
}