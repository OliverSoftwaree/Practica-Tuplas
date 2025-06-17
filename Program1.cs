using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = Sumar(numero1, numero2);

        Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }
}