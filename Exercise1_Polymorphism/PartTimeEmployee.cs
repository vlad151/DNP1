namespace Exercise1_Polymorphism;

public class PartTimeEmployee : Employee
{
    public double HourlyWage;
    public int HoursPerMonth;

    public PartTimeEmployee(string Name, double HourlyWage, int HoursPerMoth) : base(Name)
    {
        this.HourlyWage = HourlyWage;
        this.HoursPerMonth = HoursPerMoth;
    }
    
    public override double GetMonthlySalary()
    {
        return HourlyWage * HoursPerMonth;
    }
}