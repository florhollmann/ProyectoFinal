using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionProfesores
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Usuario objEntidadUsuario = new Entidades.Usuario();
            //pedir datos al usuario
            Console.Write("Nombre:");
            objEntidadUsuario.NombreUsuario = Console.ReadLine();
            Console.Write("Apellido");
            objEntidadUsuario.ApellidoUsuario = Console.ReadLine();
            Console.Write("Email:");
            objEntidadUsuario.EmailUsuario = Console.ReadLine();
            Logica.Usuario objLogicaUsuario = new Logica.Usuario();
            objLogicaUsuario.Agregar(objEntidadUsuario);
            Console.WriteLine("Usuario Agregado!");
            Console.ReadKey();
        }
    }
}
