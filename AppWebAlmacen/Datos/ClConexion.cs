using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Datos
{
    public class ClConexion
    {
        public SqlConnection mtdConexion()
        {
            conexion = new SqlConnection("Data Source=SOGAPRRBCFSD534\\SQLEXPRESS;Initial Catalog=dbAlmacen;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}