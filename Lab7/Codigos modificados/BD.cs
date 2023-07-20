        private void createSesion(String Nombre, String Apellido)
        {
            Session["Nombre"] = Nombre;
            Session["Apellido"] = Apellido;
        }

        //creacion de las cookies
        private void createCookie(String Sexo, String Ciudad)
        {
            HttpCookie cookie1 = new HttpCookie("sexo", Sexo);
            HttpCookie cookie2 = new HttpCookie("ciudad", Ciudad);
            Response.Cookies.Add(cookie1);
            Response.Cookies.Add(cookie2);
            
        }