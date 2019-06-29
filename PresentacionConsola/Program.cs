

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            //pedir datos al usuario
            Console.Write("ISBN del libro:");
            objEntidadLibro.IsbnLibro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre del libro");
            objEntidadLibro.NombreLibro = Console.ReadLine();
            Console.Write("Nombre del autor");
            objEntidadLibro.NombreAutor = Console.ReadLine();
            Console.Write("Apellido del Autor");
            objEntidadLibro.ApellidoAutor = Console.ReadLine();
            Logica.Libro objLogicaLibro = new Logica.Libro();
            objLogicaLibro.Agregar(objEntidadLibro);
            Console.WriteLine("Libro agregado!");
            Console.ReadKey();
            
        }
    }
}
