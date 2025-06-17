using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el radio del círculo: ");
        if (double.TryParse(Console.ReadLine(), out double radio))
        {
            double area = CalcularAreaCirculo(radio);
            Console.WriteLine($"El área del círculo es: {area:F2}");
        }
        else
        {
            Console.WriteLine("Introduce un valor numérico válido para el radio.");
        }
    }

    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}