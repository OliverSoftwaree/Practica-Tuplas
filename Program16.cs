using System;

class Program
{
    static void Main()
    {
        var tupla = (10, 20, 30, 40, 50);

        
        int longitud = 5;

        Console.WriteLine($"La tupla es: ({tupla.Item1}, {tupla.Item2}, {tupla.Item3}, {tupla.Item4}, {tupla.Item5})");
        Console.WriteLine($"La longitud de la tupla es: {longitud}");
    }
}
