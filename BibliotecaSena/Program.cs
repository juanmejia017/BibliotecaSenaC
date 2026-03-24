using System;
using Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SISTEMA DE GESTION DE BIBLIOTECA");

        Console.ReadKey();

        // Primero prueba modelos
        TestModels();

        // Luego menú principal
        ShowMainMenu();
    }

    static void TestModels()
    {
        Console.WriteLine("\n=== PRUEBA DE MODELOS ===\n");

        Libro libro1 = new Libro(1, "Cien años de soledad", "Gabriel García Márquez", 1967, "Novela");
        Libro libro2 = new Libro(2, "1984", "George Orwell", 1949, "Distopía");

        Usuario user1 = new Usuario(1, "Juan", "123", "juan@email.com");
        Usuario user2 = new Usuario(2, "Ana", "456", "ana@email.com");

        Prestamo prestamo = new Prestamo(1, libro1, user1, DateTime.Now.AddDays(-10));

        Console.WriteLine("=== LIBROS ===");
        Console.WriteLine(libro1.ResumenCorto());
        Console.WriteLine(libro1.DetalleCompleto());

        Console.WriteLine("\n=== USUARIOS ===");
        Console.WriteLine(user1.ResumenCorto());
        Console.WriteLine(user1.DetalleCompleto());

        Console.WriteLine("\n=== PRÉSTAMO ===");
        Console.WriteLine(prestamo.DetalleCompleto());
        Console.WriteLine($"¿Está vencido?: {prestamo.EstaVencido()}");
        Console.WriteLine($"Días transcurridos: {prestamo.DiasTranscurridos()}");

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
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
            Console.WriteLine("4. Busquedas y reportes");
            Console.WriteLine("5. Guardar / cargar datos");
            Console.WriteLine("6. Salir");

            Console.Write("\nSeleccione una opción: ");
            string option = Console.ReadLine().Trim();

            switch (option)
            {
                case "1": ShowBooksMenu(); break;
                case "2": ShowUserMenu(); break;
                case "3": ShowLoansMenu(); break;
                case "4": ShowSearchReportsMenu(); break;
                case "5": SaveAndLoadData(); break;
                case "6": ConfirmExitAndSave(); break;
                default: ShowErrorMessage(); break;
            }
        }
    }

    // 🔽 El resto de tus métodos siguen igual (NO había errores ahí)
}

        

