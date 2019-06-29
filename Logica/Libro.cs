using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Libro
    {
        //en logica van los metodos!
        //Metodos
        /// <summary>
        /// Metodo que tiene la funcion de agregar un libro en la tabla LIBROS
        /// Creado por flor
        /// Fecha de creacion : 21/06/2019
        /// </summary>
        /// <param name="pLibro"></param>

        public void Agregar(Entidades.Libro pLibro)
        {
            // TODO llamar a metodo agregar de la capa de datos
            Datos.Libro objLibro = new Datos.Libro();
            objLibro.Agregar(pLibro);
        }
    }
}
