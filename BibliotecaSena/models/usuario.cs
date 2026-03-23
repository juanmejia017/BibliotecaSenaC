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

        public Usuario()
        {
            Activo = true;
        }

        public Usuario(int id, string nombre, string documento, string email)
        {
            Id = id;
            Nombre = nombre;
            Documento = documento;
            Email = email;
            Activo = true;
        }

        public string ResumenCorto()
        {
            return $"{Nombre} - {Documento}";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id}\nNombre: {Nombre}\nDocumento: {Documento}\nEmail: {Email}\nActivo: {Activo}";
        }

        public override string ToString()
        {
            return $"{Nombre} ({(Activo ? "Activo" : "Inactivo")})";
        }
    }
}

