using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadSession();
            deleteSessions();
        }
        private void loadSession()
        {
            String nombre = (String)(Session["Nombre"]);
            String apellido = (String)(Session["Apellido"]);

            usuario.Text = "Enviado por Sesion:\n";
            name.Text = "Nombre: " + nombre;
            secondname.Text = "\nApellido: " + apellido + ";";
        }
        private void deleteSessions()
        {
            Session.RemoveAll();
            Session.Abandon();
        }
    }

}