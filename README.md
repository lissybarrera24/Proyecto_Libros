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


Public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    public Persona (string nombre, string apellido, int edad)
{
    Nombre= nombre;
    Apellido= apellido;
    Edad= edad;
}
public void Saludar()
{
    Console.WriteLine($"¡Hola! Soy {Sofia} {Garcia} y tengo {25} años.");  
   }
 }
}
