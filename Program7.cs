using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<int> numeros = new List<int> { 5, 10, 15, 20, 25 };

        Console.Write("Introduce un número para verificar si está en la lista: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (NumeroEnLista(numero, numeros))
            {
                Console.WriteLine($"{numero} sí está en la lista.");
            }
            else
            {
                Console.WriteLine($"{numero} no está en la lista.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, introduce un valor numérico válido.");
        }
    }

    static bool NumeroEnLista(int numero, List<int> lista)
    {
        return lista.Contains(numero);
    }
}