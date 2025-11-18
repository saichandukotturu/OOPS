using System;
public class Car
{
    public string Brand;
    public int Speed;

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving at {Speed} km/h");
    }
}