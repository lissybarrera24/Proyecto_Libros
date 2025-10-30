# Proyecto_Libros
Libro.cs
Public class Libro 
{
    public string Titulo { get; set; }
    public string  Autor { get; set; }
    public int AñoPublicacion { get; set; }

    public Libro(string titulo, string autor, int año publicacion )
{
           Titulo = titulo; 
           Autor= autor;
           AñoPublicacion = añopublicacion 
}
   public void MostrarInformacion(
{
        Console.WriteLine($"Titulo: { Titulo}, Autor: {Autor}, Año: { AñoPublicacion}");
       }
    }
}


