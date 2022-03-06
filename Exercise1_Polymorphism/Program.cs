namespace Exercise1_Polymorphism
{
    class Program
    {
        public static void Main(String[] args)
        {
            Company company = new();
            company.HireNewEmployee(new FullTimeEmployee("bob", 100));
            company.HireNewEmployee(new PartTimeEmployee("chris",5, 10));
            
            Console.WriteLine(company.GetMonthlySalaryTotal());
            
        }
    }
}

