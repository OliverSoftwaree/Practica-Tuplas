using System;

class Libro
{
    public string Titulo { get; set; }

    public Libro(string titulo)
    {
        Titulo = titulo;
    }

    public void ImprimirTitulo()
    {
        Console.WriteLine($"El título del libro es: {Titulo}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Introduce el título del libro: ");
        string? titulo = Console.ReadLine();

        Libro libro = new Libro(titulo ?? string.Empty);
        libro.ImprimirTitulo();
    }
}