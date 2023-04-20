using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Datos
{
    public class ClProductoD
    {
        public int mtdRegistrarProd(ClProductoE objProd)
        {
            string registrar = "Insert into Producto(codigo,nombre,descricpion,precio,imagenProducto,idCategoria) Values('" + objProd.codigo + "','" + objProd.nombre + "','" + objProd.descripcion + "'," +
                "" + objProd.precio + ",'" + objProd.imagenProd + "'," + objProd.idCategoria + ")";
            ClProcesarSQL SQL = new ClProcesarSQL();
            int regis = SQL.mtdIUDconect(registrar);
            return regis;
        }
        public int mtdVerificar(string codigo)
        {
            string consulta = "Select Count(*) from Producto where codigo ='" + codigo + "'";
            ClProcesarSQL SQL = new ClProcesarSQL();
            int verificar = SQL.mtdIUDconect(consulta);
            return verificar;
        }
    }
}