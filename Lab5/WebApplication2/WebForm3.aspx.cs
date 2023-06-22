using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string filePath = Server.MapPath("~/ciudades.txt");
                string[] ciudades = File.ReadAllLines(filePath);

                foreach (string ciuda in ciudades)
                {
                    ListItem item = new ListItem(ciuda, ciuda);
                    ciudad.Items.Add(item);
                }
            }
        }

        protected void Save(object sender, EventArgs e)
        {
            string nombreValue = nombre.Text;
            string apellidoValue = apellido.Text;
            string sexoValue = sexoF.Checked ? sexoF.Text : sexoM.Text;
            string emailValue = email.Text;
            string direccionValue = direccion.Text;
            string ciudadValue = ciudad.Value;
            string requerimientoValue = requerimiento.Value;

            if (string.IsNullOrEmpty(nombreValue) || !System.Text.RegularExpressions.Regex.IsMatch(nombreValue, "^[A-Za-zÁÉÍÓÚáéíóúÑñ]+$"))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El nombre solo puede contener letras.');", true);
                return;
            }

            if (string.IsNullOrEmpty(apellidoValue) || !System.Text.RegularExpressions.Regex.IsMatch(apellidoValue, "^[A-Za-zÁÉÍÓÚáéíóúÑñ]+\\s[A-Za-zÁÉÍÓÚáéíóúÑñ]+\\s?[A-Za-zÁÉÍÓÚáéíóúÑñ]*$"))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El apellido debe tener un formato válido (dos apellidos separados por espacio).');", true);
                return;
            }

            if (!sexoF.Checked && !sexoM.Checked)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe seleccionar una opción de género.');", true);
                return;
            }

            if (string.IsNullOrEmpty(emailValue) || !System.Text.RegularExpressions.Regex.IsMatch(emailValue, "^[A-Za-z0-9._%+-]+@unsa\\.edu\\.pe$"))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El correo electrónico debe terminar \'@unsa.edu.pe\'.');", true);
                return;
            }

            if (string.IsNullOrEmpty(ciudadValue))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe seleccionar una ciudad válida.');", true);
                return;
            }

            string currentDate = DateTime.Now.ToString();
            string textoGenerado = "Nombre: " + nombreValue + "\n" +
                "Apellido: " + apellidoValue + "\n" +
                "Sexo: " + sexoValue + "\n" +
                "Email: " + emailValue + "\n" +
                "Dirección: " + direccionValue + "\n" +
                "Ciudad: " + ciudadValue + "\n" +
                "Requerimiento: " + requerimientoValue + "\n" +
                "Fecha y hora: " + currentDate;

            resultado.Value = textoGenerado;
            resultado.Style["display"] = "block";

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El formulario ha sido enviado exitosamente. Fecha y hora: " + currentDate + "');", true);
        }
        protected void limpiar()
        {
            nombre.Text = string.Empty;
            apellido.Text = string.Empty;
            sexoF.Checked = false;
            sexoM.Checked = false;
            email.Text = string.Empty;
            direccion.Text = string.Empty;
            requerimiento.Value = string.Empty;
            ciudad.Value = string.Empty;
            resultado.Value = string.Empty;
            resultado.Style["display"] = "none";
        }
        protected void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
