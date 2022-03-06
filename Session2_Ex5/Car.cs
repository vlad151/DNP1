namespace Session2_Ex5;

public class Car
{
    public String Color { get; }
    private bool IsManualShift;
    private int EngineSize;
    private double FuelEconomy;

    public Car(string color, bool isManualShift, int engineSize, double fuelEconomy)
    {
        Color = color;
        IsManualShift = isManualShift;
        EngineSize = engineSize;
        FuelEconomy = fuelEconomy;
    }

    

    public override string ToString()
    {
        return $"color: {Color}; engine size {EngineSize}; consumption {FuelEconomy}; manual shift {IsManualShift}";
    }
}