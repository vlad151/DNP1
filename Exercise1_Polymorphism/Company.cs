namespace Exercise1_Polymorphism;

public class Company
{
    private List<Employee> employees = new List<Employee>();


    public double GetMonthlySalaryTotal()
    {
        double total = 0;
        foreach (var employee in employees)
        {
            total += employee.GetMonthlySalary();
        }

        return total;
    }

    public void HireNewEmployee(Employee emp)
    {
        employees.Add(emp);
    }
}