using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class VistaLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Logica.Libro objLogica = new Logica.Libro();
            GValumnos.DataSource = objLogica.TraerTodos();
        }
    }
}