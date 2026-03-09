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

     static void ShowUserMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE USUARIOS ===");
            Console.WriteLine("2.1 Registrar Usuario");
            Console.WriteLine("2.2 Listar Usuarios");
            Console.WriteLine("2.3 Ver detalle (por ID/documento)");
            Console.WriteLine("2.4 Actualizar Usuario");
            Console.WriteLine("2.5 Eliminar Usuario");
            Console.WriteLine("0. Volver al menú principal");

            string option = Console.ReadLine().Trim();
            switch (option)
            {
                case "2.1": RegisterUser(); break;
                case "2.2": ListUser(); break;
                case "2.3": ViewUserDetail(); break;
                case "2.4": UpdateUserMenu(); break;
                case "2.5": DeleteUser(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }
        }
    }

    static void RegisterUser() { Console.WriteLine("Registrando usuario..."); Console.ReadKey(); }
    static void ListUser() { Console.WriteLine("Mostrando listado de usuarios..."); Console.ReadKey(); }
    static void ViewUserDetail() { Console.WriteLine("Mostrando detalles por ID..."); Console.ReadKey(); }

    static void UpdateUserMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR USUARIO ===");
            Console.WriteLine("2.4.1 Editar Nombre");
            Console.WriteLine("2.4.2 Editar contacto");
            Console.WriteLine("2.4.3 Activar/desactivar");
            Console.WriteLine("0. Volver al menú de Usuarios");

            string opt = Console.ReadLine().Trim();
            switch (opt)
            {
                case "2.4.1": EditUserName(); break;
                case "2.4.2": EditUserContact(); break;
                case "2.4.3": ToggleUserActiveStatus(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }

            if (!back) Console.ReadKey();
        }
    }

    static void EditUserName() { Console.WriteLine("Editando el nombre del usuario..."); }
    static void EditUserContact() { Console.WriteLine("Editando el contacto del usuario..."); }
    static void ToggleUserActiveStatus() { Console.WriteLine("Verificando estado del usuario..."); }
    static void DeleteUser() { Console.WriteLine("Validar: No permitir si tiene préstamos activos");Console.ReadKey();}


    static void ShowLoansMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE PRÉSTAMOS ===");
            Console.WriteLine("3.1 Crear préstamo");
            Console.WriteLine("3.2 Listar préstamos");
            Console.WriteLine("3.3 Ver detalle");
            Console.WriteLine("3.4 Registrar devolución");
            Console.WriteLine("3.5 Eliminar préstamo");
            Console.WriteLine("0. Volver");

            string option = Console.ReadLine().Trim();
            switch (option)
            {
                case "3.1": CreateLoan(); break;
                case "3.2": ListLoanMenu(); break;
                case "3.3": ViewLoanDetail(); break;
                case "3.4": RegisterReturn(); break;
                case "3.5": DeleteLoan(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }

            if (!back) Console.ReadKey();
        }
    }

    static void CreateLoan() { Console.WriteLine("Creando préstamo..."); }
    static void ListLoanMenu()
    {
        bool back = false;
        while (!back)
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR PRÉSTAMOS ===");
            Console.WriteLine("3.2.1 Todos");
            Console.WriteLine("3.2.2 Activos");
            Console.WriteLine("3.2.3 Cerrados");
            Console.WriteLine("0. Volver al menú de Préstamos");

            string opt = Console.ReadLine().Trim();
            switch (opt)
            {
                case "3.2.1": ListLoanAll(); break;
                case "3.2.2": ListLoanActive(); break;
                case "3.2.3": ListLoanClosed(); break;
                case "0": back = true; break;
                default: ShowErrorMessage(); break;
            }

            if (!back) Console.ReadKey();
        }
    }

    static void ListLoanAll() { Console.WriteLine("Listando todos los préstamos..."); }
    static void ListLoanActive() { Console.WriteLine("Listando préstamos activos..."); }
    static void ListLoanClosed() { Console.WriteLine("Listando préstamos cerrados..."); }
    static void ViewLoanDetail() { Console.WriteLine("Consultando detalles por ID..."); }
    static void RegisterReturn() { Console.WriteLine("Devolución registrada. ¡Libro disponible!"); }
    static void DeleteLoan() { Console.WriteLine("Reglas sugeridas..."); }

        
}
