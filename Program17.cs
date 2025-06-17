using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var ciudades = ("Madrid", "Barcelona", "Valencia", "Sevilla", "Bilbao");

        // Convertir la tupla en una lista
        List<string> listaCiudades = new List<string>
        {
            ciudades.Item1,
            ciudades.Item2,
            ciudades.Item3,
            ciudades.Item4,
            ciudades.Item5
        };

        Console.WriteLine("Lista de ciudades:");
        foreach (var ciudad in listaCiudades)
        {
            Console.WriteLine(ciudad);
        }
    }
}