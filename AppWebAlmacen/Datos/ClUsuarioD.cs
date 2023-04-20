using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Datos
{
    public class ClUsuarioD
    {
        public int mtdRegistrar(ClUsuarioEn objDatos)
        {
            string consulta = "insert into Usuario(documento, nombre, apellido, email, clave)" +
                "values('" + objDatos.documento + "', '" + objDatos.nombre + "', '" + objDatos.apellido + "', " +
                "'" + objDatos.email + "', '" + objDatos.clave + "')";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            int canReg = objSQL.mtdIUDconect(consulta);
            return canReg;
        }
    }
}