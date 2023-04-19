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
            conexion = new SqlConnection("");
            conexion.Open();
            return conexion;
        }
    }
}