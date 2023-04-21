using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Datos
{
    public class ClRolD
    {
        public List<ClRolE> mtdListarRol()
        {
            string consul = "Select * from Rol";
            ClProcesarSQL SQL = new ClProcesarSQL();
            DataTable tblRol = SQL.mtdSelectDes(consul);

            List<ClRolE> listRol = new List<ClRolE>();
            ClRolE objRol = null;
            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                objRol = new ClRolE();
                objRol.idRol = int.Parse(tblRol.Rows[i]["idRol"].ToString());
                objRol.rol = tblRol.Rows[i]["rol"].ToString();
                listRol.Add(objRol);
            }
            return listRol;

        }
    }
}