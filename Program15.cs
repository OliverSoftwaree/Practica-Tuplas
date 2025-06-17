using System;

class Program
{
    static void Main()
    {
        var tupla = ("a", "b", "c");
        Console.WriteLine($"La tupla es: ({tupla.Item1}, {tupla.Item2}, {tupla.Item3})");
    }
}
