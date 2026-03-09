using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SISTEMA DE GESTION DE BIBLIOTECA");
    }
          ShowMainMenu();
    
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
                case "6":ConfirmExitAndSave(); break;
                default: ShowErrorMessage(); break;
            }
        }
    }
    static void ShowBooksMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE LIBROS ===");
            Console.WriteLine("1.1 Registrar Libro");
            Console.WriteLine("1.2 Listar Libros");
            Console.WriteLine("1.3 Ver Detalle por (ID/ISBN)");
            Console.WriteLine("1.4 Actualizar Libro");
            Console.WriteLine("1.5 Eliminar Libro");
            Console.WriteLine("0. Volver al Menu Principal");

            string option = Console.ReadLine().Trim();
            switch (option)
            {
                case "1.1": RegisterBook(); break;
                case "1.2": ListBooksMenu(); break;
                case "1.3": ViewBookDetail(); break;
                case "1.4": UpdateBookMenu(); break;
                case "1.5": DeleteBook(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }
        }
    }

    static void RegisterBook()
    {
        Console.WriteLine("Registrando un Nuevo Libro...");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListBooksMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR LIBROS ===");
            Console.WriteLine("1.2.1 Listar Todos");
            Console.WriteLine("1.2.2 Listar Disponibles");
            Console.WriteLine("1.2.3 Listar Prestados");
            Console.WriteLine("0. Volver al menú de Libros");

            string opt = Console.ReadLine().Trim();
            switch (opt)
            {
                case "1.2.1": ListBooksAll(); break;
                case "1.2.2": ListBooksAvailable(); break;
                case "1.2.3": ListBooksBorrowed(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }

            if (!back)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void ListBooksAll() { Console.WriteLine("Listado de todos los libros registrados..."); }
    static void ListBooksAvailable() { Console.WriteLine("Listado de los libros disponibles..."); }
    static void ListBooksBorrowed() { Console.WriteLine("Listado de libros prestados..."); }

    static void ViewBookDetail()
    {
        Console.WriteLine("Mostrando detalles por ID/ISBN...");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void UpdateBookMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR LIBRO ===");
            Console.WriteLine("1.4.1 Editar título");
            Console.WriteLine("1.4.2 Editar autor");
            Console.WriteLine("1.4.3 Editar año/categoría");
            Console.WriteLine("0. Volver al menú de Libros");

            string opt = Console.ReadLine().Trim();
            switch (opt)
            {
                case "1.4.1": EditBookTitle(); break;
                case "1.4.2": EditBookAuthor(); break;
                case "1.4.3": EditBookYearCategory(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }

            if (!back)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void EditBookTitle() { Console.WriteLine("Editando el título del libro..."); }
    static void EditBookAuthor() { Console.WriteLine("Editando el autor del libro..."); }
    static void EditBookYearCategory() { Console.WriteLine("Editando el año o categoría del libro..."); }
    static void DeleteBook() { Console.WriteLine("Validar: Si el libro está prestado no se puede eliminar");Console.ReadKey(); }



        
}
