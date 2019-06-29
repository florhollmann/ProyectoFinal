using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario
    {
        public void Agregar(Entidades.Usuario pUsuario)
        {
            Datos.Usuario objUsuario = new Datos.Usuario();
            objUsuario.Agregar(pUsuario);
        }


    }
}
