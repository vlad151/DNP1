namespace Exercise7
{
    class Program
    {

        public string ABBA(string string1, string stirng2)
        {
            return ($"{string1}{stirng2}{stirng2}{string1}");
        }
        public static void Main(string[] args)
        {
            Program p1 = new();
           Console.WriteLine( p1.ABBA("hej", "nej"));
        }
    }
}

