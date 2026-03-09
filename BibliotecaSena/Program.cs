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

        
}
