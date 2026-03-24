using System;
using System.Collections.Generic;
using Models;

class Program
{
    static List<Libro> libros = new List<Libro>();
    static List<Usuario> usuarios = new List<Usuario>();
    static List<Prestamo> prestamos = new List<Prestamo>();

    static void Main(string[] args)
    {
        TestModels();
        ShowMainMenu();
    }

    static void TestModels()
    {
        libros.Add(new Libro(1, "Cien años de soledad", "Gabriel García Márquez", 1967, "Novela"));
        libros.Add(new Libro(2, "Clean Code", "Robert C. Martin", 2008, "Tecnología"));

        usuarios.Add(new Usuario(1, "Carlos Mejia", "123456", "carlos@mail.com"));
        usuarios.Add(new Usuario(2, "Sara Gomez", "654321", "sara@mail.com"));

        prestamos.Add(new Prestamo(1, libros[0], usuarios[0], DateTime.Now.AddDays(-10)));
        libros[0].Disponible = false;
    }

    static void ShowMainMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("== MENU PRINCIPAL ==");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Prestamos");
            Console.WriteLine("6. Salir");

            Console.Write("\nSeleccione una opción: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1": ShowBooksMenu(); break;
                case "2": ShowUserMenu(); break;
                case "3": ShowLoansMenu(); break;
                case "6": exit = true; break;
                default: break;
            }
        }
    }

    static void ShowBooksMenu()
    {
        Console.Clear();
        Console.WriteLine("=== LISTADO DE LIBROS (TESTING) ===");
        foreach (var libro in libros)
        {
            Console.WriteLine($"\n{libro.ResumenCorto()}");
            Console.WriteLine(libro.DetalleCompleto());
        }
        Console.WriteLine("\nPresione una tecla para volver...");
        Console.ReadKey();
    }

    static void ShowUserMenu()
    {
        Console.Clear();
        Console.WriteLine("=== LISTADO DE USUARIOS (TESTING) ===");
        foreach (var u in usuarios)
        {
            Console.WriteLine($"\n{u.ResumenCorto()}");
            Console.WriteLine(u.DetalleCompleto());
        }
        Console.WriteLine("\nPresione una tecla para volver...");
        Console.ReadKey();
    }

    static void ShowLoansMenu()
    {
        Console.Clear();
        Console.WriteLine("=== LISTADO DE PRÉSTAMOS (TESTING) ===");
        foreach (var p in prestamos)
        {
            Console.WriteLine($"\n{p.ResumenCorto()}");
            Console.WriteLine(p.DetalleCompleto());
            Console.WriteLine($"¿Vencido?: {p.EstaVencido()} | Días: {p.DiasTranscurridos()}");
        }
        Console.WriteLine("\nPresione una tecla para volver...");
        Console.ReadKey();
    }
}
    

   




        

