namespace MathLib;

public class Calculator
{
    public decimal Add(decimal num1, decimal num2)
    {
        return num1 + num2;
    }

    public int Add(int[] arrayOfInts)
    {
        int sum = 0;
        foreach (var number in arrayOfInts)
        {
            sum += number;
        }

        return sum;
    }

    public int Compare()
    {
        Console.WriteLine("What is the first number that you want to compare? :");
         var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the second number tha you want to compare? :");
        var num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} is greater than {num2}");
            return num1;
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"{num2} is greater than {num1}");
            return num2;
        }
        else
        {
            Console.WriteLine("The numbers are equal");
            return 0;
        }
    }
}