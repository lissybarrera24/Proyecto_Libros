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
