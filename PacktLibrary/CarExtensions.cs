namespace Packt.Shared;

public static class CarExtensions
{
    public static Car SetModel(this Car car, string model)
    {
        car.Model = model;
        return car;
    }

    public static Car SetColor(this Car car, string color)
    {
        car.Color = color;
        return car;
    }

    public static void PrintCarDetails(this Car car)
    {
        WriteLine($"{car.Model} : {car.Color}");
    }
}
