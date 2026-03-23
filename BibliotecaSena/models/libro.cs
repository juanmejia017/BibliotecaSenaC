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
public string ResumenCorto()
{
    return $"{Titulo} - {Autor}";
}

public string DetalleCompleto()
{
    return $"ID: {Id}\nTitulo: {Titulo}\nAutor: {Autor}\nAño: {Año}\nCategoria: {Categoria}\nDisponible: {Disponible}";
}

public override string ToString()
{
    return $"{Titulo} ({Año}) - {(Disponible ? "Disponible" : "Prestado")}";
}
        
    }
}