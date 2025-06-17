using System;

class Coche
{
    public string Color { get; set; }

    public Coche(string color)
    {
        Color = color;
    }

    public string ObtenerColor()
    {
        return Color;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Introduce el color del coche: ");
        string? color = Console.ReadLine();

        Coche coche = new Coche(color ?? string.Empty);
        Console.WriteLine($"El color del coche es: {coche.ObtenerColor()}");
    }
}