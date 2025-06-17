using System;

class Program
{
    static void Main()
    {
        var tupla = (2, 4, 2, 5, 2, 4);

        Console.Write("Introduce el número a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int numeroBuscado))
        {
            int cantidad = ContarOcurrencias(tupla, numeroBuscado);
            Console.WriteLine($"El número {numeroBuscado} aparece {cantidad} veces en la tupla.");
        }
        else
        {
            Console.WriteLine("Por favor, introduce un valor numérico válido.");
        }
    }

    static int ContarOcurrencias((int, int, int, int, int, int) tupla, int numero)
    {
        int contador = 0;
        if (tupla.Item1 == numero) contador++;
        if (tupla.Item2 == numero) contador++;
        if (tupla.Item3 == numero) contador++;
        if (tupla.Item4 == numero) contador++;
        if (tupla.Item5 == numero) contador++;
        if (tupla.Item6 == numero) contador++;
        return contador;
    }
}