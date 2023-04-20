using AppWebAlmacen.Datos;
using AppWebAlmacen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAlmacen.Logica
{
    public class ClProductoL
    {
        public int mtdRegistraPro(ClProductoE objProd)
        {
            ClProductoD objProduc = new ClProductoD();
            int regis = objProduc.mtdRegistrarProd(objProd);
            return regis;
        }

        public int mtdVerificar(string codigo)
        {
            ClProductoD objProd = new ClProductoD();
            int verif = objProd.mtdVerificar(codigo);
            return verif;
        }
    }
}