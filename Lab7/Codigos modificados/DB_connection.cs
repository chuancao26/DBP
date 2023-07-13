using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectDataBase.DataBaseCode;

namespace ProjectDataBase
{
    class DB_connection 
    {
        public static void Main(String[] args)
        {
            DB_connection d = new DB_connection();
            d.queryCity();
            Console.ReadKey();
        }

        private void queryCity()
        {
            BD database = new BD();
            IList<String> ciudades = database.getCiudades();
            if (ciudades == null)
            {
                Console.WriteLine("No data");
                return;
            }
            for (int i = 0; i < ciudades.Count; i++)
            {
                Console.WriteLine(ciudades[i]);
            }
        }
    }
}
