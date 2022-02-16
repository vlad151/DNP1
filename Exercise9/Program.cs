namespace Exercise9
{
    class Program
    {
        public string Substring(string s, int i)
        {
            string final = "";

            for (int j = 0; j < i; j++)
            {
                final += s[j];
            }

            for (int k = s.Length-i; k < s.Length; k++)
            {
                final += s[k];
            }

            return final;
        }
        
        public static void Main(string[] args)
        {
            Program p1 = new();
            Console.WriteLine(p1.Substring("Chocolate",1));
        }
    }
}

