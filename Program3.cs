using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EsPar(numero))
            {
                Console.WriteLine($"{numero} es un número par.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número par.");
            }
        }
        else
        {
            Console.WriteLine("Introduce un valor numérico válido.");
        }
    }

    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}