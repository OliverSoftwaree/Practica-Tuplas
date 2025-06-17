using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.Write("Introduce el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                double mayor = EncontrarMayor(numero1, numero2);
                Console.WriteLine($"El mayor de los dos números es: {mayor}");
            }
            else
            {
                Console.WriteLine("Introduce un valor numérico válido para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Introduce un valor numérico válido para el primer número.");
        }
    }

    static double EncontrarMayor(double a, double b)
    {
        return (a > b) ? a : b;
    }
}