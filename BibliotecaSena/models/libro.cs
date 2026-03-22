using System;

namespace Models
{
    public class Libro
    {
      public int Id { get; set; }
public string Titulo { get; set; }
public string Autor { get; set; }
public int Año { get; set; }
public string Categoria { get; set; }
public bool Disponible { get; set; } = true;  

public Libro()
{
    Disponible = true;
}

public Libro(int id, string titulo, string autor, int año, string categoria)
{
    Id = id;
    Titulo = titulo;
    Autor = autor;
    Año = año;
    Categoria = categoria;
    Disponible = true;
}
        
    }
}