using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class AltaLibro : System.Web.UI.Page
    {

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Entidades.Libro objEntidadLibro = new Entidades.Libro();
            Logica.Libro objLogicaLibro = new Logica.Libro();

            
            objEntidadLibro.IsbnLibro = Convert.ToInt32(ISBN.Text);
        
            objEntidadLibro.NombreLibro = NombreLibro.Text;
        
            objEntidadLibro.NombreAutor = NombreAutor.Text;
        
            objEntidadLibro.ApellidoAutor = ApellidoAutor.Text;
            
            objLogicaLibro.Agregar(objEntidadLibro);
            lblMensaje.Text ="Libro agregado!";
        }
    }
}