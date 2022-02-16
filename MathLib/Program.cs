namespace MathLib
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new();

            Console.WriteLine(calculator.Add(69, 420));

            int[] arrayOfInts = new[] {69, 420, 1337, 322, 228};
            Console.WriteLine(calculator.Add(arrayOfInts));

            calculator.Compare();
        }
    }
}