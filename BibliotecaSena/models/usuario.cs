using System;

namespace models
{
    public class Usuario
    {
        public int Id {get;set;}
         public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; } = true;
        
    }
}