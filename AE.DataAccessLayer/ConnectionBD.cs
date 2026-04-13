using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE.DataAccessLayer
{
    public class ConnectionBD
    {
        private static readonly string cadena =
            @"server=.\SQLEXPRESS; database=AgendaElectronicaDB; integrated security=true; TrustServerCertificate=True;";

        public static SqlConnection conectar()
        {
            return new SqlConnection(cadena);
        }
    }
}
