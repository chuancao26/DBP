using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace ProjectDataBase.DataBaseCode
{
    public class BD
    {
        private string connectionString;
        private SqlConnection connection;
        public List<string> getCiudades()
        {
            List<string> ciudades = new List<string>();
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WEBDB1; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT Ciudad FROM DataCiudad";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string city = reader["Ciudad"].ToString();
                ciudades.Add(city);
            }
            connection.Close();
            return ciudades;
        }
        public void insertarRecord(string nom, string ape, string sex, string ema, string dir, int ciu, string req)
        {
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WEBDB1; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO [dbo].[DataAlumnos] ([Nombre], [Apellidos], [Sexo] ,[Email] , [Direccion], [CodeCiudad], [Requerimiento])" +
                "VALUES (@Nom,@Ape,@Sex, @Ema,@Dir,@Ciu,@Req)";
            SqlCommand sqlcommand = new SqlCommand(query, connection);
            sqlcommand.Parameters.AddWithValue("@Nom", nom);
            sqlcommand.Parameters.AddWithValue("@Ape", ape);
            sqlcommand.Parameters.AddWithValue("@Sex", sex);
            sqlcommand.Parameters.AddWithValue("@Ema", ema);
            sqlcommand.Parameters.AddWithValue("@Dir", dir);
            sqlcommand.Parameters.AddWithValue("@Ciu", ciu);
            sqlcommand.Parameters.AddWithValue("@Req", req);
            sqlcommand.ExecuteNonQuery();
            connection.Close();
        }
        public int getIdFromCity(string ciudad)
        {
            string id = "0";
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WEBDB1; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT Id FROM DataCiudad WHERE Ciudad=@Ciudad";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ciudad", ciudad);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader["Id"].ToString();
            }
            connection.Close();
            return int.Parse(id);
        }
    }
}
