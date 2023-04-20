using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Datos
{
    public class ClCategoriaD
    {
        public List<ClCategoriaE> mtdListaCate()
        {
            string consul = "Select idCategoria,categoria from Categoria";
            ClProcesarSQL SQL = new ClProcesarSQL();
            DataTable tblCateg = SQL.mtdSelectDes(consul);

            List<ClCategoriaE> listCate = new List<ClCategoriaE>();
            ClCategoriaE objCate = null;
            for (int i = 0; i < tblCateg.Rows.Count; i++)
            {
                objCate = new ClCategoriaE();
                objCate.idCategoria = int.Parse(tblCateg.Rows[i]["idCategoria"].ToString());
                objCate.categoria = tblCateg.Rows[i]["categoria"].ToString();
                listCate.Add(objCate);
            }
            return listCate;
        }
    }
}