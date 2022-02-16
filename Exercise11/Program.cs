namespace Exercise11
{
    class Program
    {

        public int CountClumps(int[] arrayOfInts)
        {
            int numberOfClumps = 0;
            
            for (int i = 1; i < arrayOfInts.Length-1; i++)
            {
                if ((arrayOfInts[i - 1] == arrayOfInts[i] && arrayOfInts[i] != arrayOfInts[i + 1]  ))
                {
                    numberOfClumps++;
                }
            }

            if (arrayOfInts[arrayOfInts.Length-1] == arrayOfInts[arrayOfInts.Length-2])
            {
                numberOfClumps++;
            }

            return numberOfClumps;
        }
        public static void Main(string[] args)
        {
            Program p1= new();
            int[] arrayOfInts = new[] {1,1,1,1,1,1,1};
            Console.WriteLine(p1.CountClumps(arrayOfInts));
        }
    }
}