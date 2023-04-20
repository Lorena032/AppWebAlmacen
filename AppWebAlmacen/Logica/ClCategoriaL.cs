using AppWebAlmacen.Datos;
using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Logica
{
    public class ClCategoriaL
    {
        public List<ClCategoriaE> mdtListar()
        {
            ClCategoriaD objCate = new ClCategoriaD();
            List<ClCategoriaE> listCate = objCate.mtdListaCate();
            return listCate;
        }
    }
}