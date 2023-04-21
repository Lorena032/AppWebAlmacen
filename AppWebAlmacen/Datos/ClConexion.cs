using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Datos
{
    public class ClConexion
    {
        SqlConnection conexion;
        public SqlConnection mtdConexion()
        {
            conexion = new SqlConnection("Data Source=SOGAPRRBCFSD531;Initial Catalog=dbAlmacen;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}