namespace Exercise1_Polymorphism;

public class FullTimeEmployee : Employee
{
    public int MonthlySalary;

    public FullTimeEmployee(string Name, int MonthlySalary) : base(Name)
    {
        this.MonthlySalary = MonthlySalary;
    }

    public override double GetMonthlySalary()
    {
        return MonthlySalary;
    }
}