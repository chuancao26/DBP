using ProjectDataBase.DataBaseCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IO;
using System.Text;

namespace ProjectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public IList<String> getCiudades()
        {
            BD bd = new BD();
            IList<String> ciudades = bd.getCiudades();
            return ciudades;
        }
        public void insertRecord(string nom, string ape, string sex, string ema, string dir, string ciu, string req)
        {
            BD b = new BD();
            int id = b.getIdFromCity(ciu);
            b.insertarRecord(nom, ape, sex, ema, dir, id, req);
        }
    }
}
