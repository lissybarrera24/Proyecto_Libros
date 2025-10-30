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


Public class Estante
{
    public int NumeroEstante { get; set; }
    public itn CapacidadMaxima { get; set;}
    public List<Libro> LibrosEnEstante { get; set; }

    public Estante(int numeroEstante, int capacidadMaxima)

    {
        NumeroEstante = numeroEstante;
        CapacidadMaxima = capacidadMaxima;
        LibrosEnEstante = new List<Libro>();
    }

    public void MostrarContenido(
    {
       Console.WriteLine($"\n Estante Nº{Numero Estante} ( Capacidad: {CapacidadMaxima} libros)");
       Console.WriteLine ("Libros en el estante:");
       foreach (var libro in LibrosEn Estante)
       {
        libro.MostrarInformacion();

       }
     }
  
     public void AgregarLibro(Libro)
     {
        if (LibrosEnEstante.Count < CapacidadMaxima)
        {
            LibrosEnEstante.Add(AgregarLibro)
            Console.WriteLine($"El Libro\"{libro.Titulo}\"fue agregado al estante {Numero Estante}.");
        
        }
        else
        {
            Console.WriteLine( "No se puede agregar mas libros el estante esta lleno.")
        }
     }
  }
}
