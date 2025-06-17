using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una cadena de texto: ");
        string? texto = Console.ReadLine();

        int cantidadVocales = ContarVocales(texto ?? string.Empty);
        Console.WriteLine($"El número de vocales en la cadena es: {cantidadVocales}");
    }

    static int ContarVocales(string texto)
    {
        int contador = 0;
        foreach (char c in texto.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }
}