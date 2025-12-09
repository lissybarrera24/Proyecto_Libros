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


Public class Program
{
    static void Main(string[] args)
    {
        //Crear Libros
        Libro libro1= new Libro("El Principito", "Antonie de Saint-Exupery", 1943);
        Libro libro2= new Libro("Cien años de soledad", "Gabriel Garcia Marquez", 1967);
        Libro libro3= new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605);

        //Crear Personas
        Persona persona1= new Persona("Sofia", "Garcia", 25);
        Persona persona2= new Persona("Carlos", "Lopez", 30);

        //Crear Estante
        Estante estante1= new estante(1,5);
        estante1.AgregarLibro1(libro1);
        estante1.AgregarLibro2(libro2);
        estante1.AgregarLibro3(libro3);

        //Mostrar Informacion 
        Console.WriteLine("Informacion de los libros");
        libro1.MostrarInformacion();
        libro2.MostrarInformacion();
        libro3.MostrarInformacion();

        estante1.MostrarContenido();

        Console.WriteLine("\n Saludo de las Personas");
        Persona1.Saludar();
        Persona2.Saludar();

        Console.WriteLine("\nPrograma Finalizado Correctamente");
        }
    }
}

