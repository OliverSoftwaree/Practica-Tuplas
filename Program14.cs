using System;

class Program
{
    static void Main()
    {
        var frutas = ("Manzana", "Banana", "Naranja");
        var verduras = ("Zanahoria", "Lechuga", "Tomate");

        var frutasYVerduras = (frutas.Item1, frutas.Item2, frutas.Item3, verduras.Item1, verduras.Item2, verduras.Item3);

        Console.WriteLine("Tupla combinada:");
        Console.WriteLine($"{frutasYVerduras.Item1}, {frutasYVerduras.Item2}, {frutasYVerduras.Item3}, {frutasYVerduras.Item4}, {frutasYVerduras.Item5}, {frutasYVerduras.Item6}");
    }
}