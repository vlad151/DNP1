namespace Session2_Ex5;

class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new("black", false, 3000, 12);
        Car car2 = new("black", true, 1200, 5.5);
        Car car3 = new("black", true, 3400, 16);
        Car car4 = new("black", false, 2400, 10);



        Car car5 = new("blue", false, 3000, 12);
        Car car6 = new("blue", true, 1200, 5.5);
        Car car7 = new("blue", true, 3400, 16);
        Car car8 = new("blue", false, 2400, 10);


        List<Car> CarList = new List<Car>() {car1, car2, car3, car4, car5, car6, car7, car8};


        List<Car> filteredList = FindAll(CarList, "black");

        foreach (var car in filteredList)
        {
            Console.WriteLine(car.ToString());
            
        }


    }

    public static List<Car> FindAll(List<Car> carList, String color)
    {
        List<Car> filteredResults = new();
        foreach (Car c in carList)
        {
            if (c.Color.Equals(color))
            {
                filteredResults.Add(c);
            }
        }

        return filteredResults;
    }


}