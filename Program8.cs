using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una cadena de texto: ");
        string? texto = Console.ReadLine();

        int longitud = ObtenerLongitud(texto ?? string.Empty);
        Console.WriteLine($"La longitud de la cadena es: {longitud}");
    }

    static int ObtenerLongitud(string cadena)
    {
        return cadena.Length;
    }
}