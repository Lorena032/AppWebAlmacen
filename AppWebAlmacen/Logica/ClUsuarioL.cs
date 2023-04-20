using AppWebAlmacen.Datos;
using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Logica
{
    public class ClUsuarioL
    {
            public int mtdRegistrar(ClUsuarioEn objDatos)
            {
                ClUsuarioD objusuarioD = new ClUsuarioD();
                int reg = objusuarioD.mtdRegistrar(objDatos);
                return reg;
            }
        }
}