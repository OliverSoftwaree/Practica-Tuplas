using System;

class Perro
{
    public string Raza { get; set; }

    public Perro(string raza)
    {
        Raza = raza;
    }

    public void ImprimirRaza()
    {
        Console.WriteLine($"La raza del perro es: {Raza}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Introduce la raza del perro: ");
        string? raza = Console.ReadLine();

        Perro perro = new Perro(raza ?? string.Empty);
        perro.ImprimirRaza();
    }
}