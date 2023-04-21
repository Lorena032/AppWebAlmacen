using AppWebAlmacen.Datos;
using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Logica
{
    public class ClRolL
    {
        public List<ClRolE> mdtListarRol()
        {
            ClRolD objRol = new ClRolD();
            List<ClRolE> listRol = objRol.mtdListarRol();
            return listRol;
        }
    }
}