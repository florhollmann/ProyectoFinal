using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        //atributos
        private int isbnLibro;
        private string nombreLibro;
        private string nombreAutor;
        private string apellidoAutor;
        private string editorial;

        public int IsbnLibro
        {
            get { return isbnLibro; }
            set { isbnLibro = value; }
        }

        public string NombreLibro
        {
            get { return nombreLibro; }
            set { nombreLibro = value; }
        }
        public string NombreAutor
        {
            get { return nombreLibro; }
            set { nombreLibro = value; }
        }
        public string ApellidoAutor
        {
            get { return apellidoAutor; }
            set { apellidoAutor = value; }
        }

        //propiedad autoimplementada
        // es lo mismo que lo que esta hecho arriba
        // lo de arriba permite modificar en caso que quieras que ApellidoAutor 
        //se guarde todo en mayuscula x ejemplo
        public string Editorial { get; set; }

    }
}
