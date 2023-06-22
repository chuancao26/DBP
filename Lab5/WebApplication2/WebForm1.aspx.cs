using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void PageLoad(object sender, EventArgs e)
        {
            if (true)
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
        //protected void Enviar_Click(object sender, EventArgs e)
        //{
        //    string nombreM = nombre.Text;
        //    string apellidoM = apellido.Text;
        //    string sexoM = (sexoF.Checked) ? "Masculino" : "Femenino";
        //    string emailM = email.Text;
        //    string direccionM = direccion.Text;
        //    string ciudadM = ciudad.Text;
        //    string requerimientoM = requerimiento.Value;
        //    resultado.InnerHtml = $"Nombre: {nombreM}<br />" +
        //                          $"Apellido: {apellidoM}<br />" +
        //                          $"Sexo: {sexoM}<br />" +
        //                          $"Email: {emailM}<br />" +
        //                          $"Dirección: {direccionM}<br />" +
        //                          $"Ciudad: {ciudadM}<br />" +
        //                          $"Requerimiento: {requerimientoM}<br />";
        //}
    }
}