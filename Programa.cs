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