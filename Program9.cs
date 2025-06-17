using System;

class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Introduce el nombre de la persona: ");
        string? nombre = Console.ReadLine();

        Persona persona = new Persona(nombre ?? string.Empty);
        persona.Saludar();
    }
}
