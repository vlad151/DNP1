namespace Exercise8
{
    class Program
    {
        public string SurroundWith(string s1, string s2)
        {
            return ($"{s1[0]}{s1[1]}{s2}{s1[2]}{s1[3]}");
        }
        
        public static void Main(string[] args)
        {
            Program p1 = new();
            Console.WriteLine(p1.SurroundWith("<<>>","dnp1"));
        }
    }
}