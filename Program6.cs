using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la temperatura en grados Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = CelsiusAFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C equivalen a {fahrenheit:F2}°F");
        }
        else
        {
            Console.WriteLine("Por favor, introduce un valor numérico válido.");
        }
    }

    static double CelsiusAFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}