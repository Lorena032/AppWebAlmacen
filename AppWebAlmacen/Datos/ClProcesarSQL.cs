using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AppWebAlmacen.Datos
{
    public class ClProcesarSQL
    {
        public DataTable mtdSelectDes(string consul)
        {
            ClConexion objConexion = new ClConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(consul, objConexion.mtdConexion());
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.mtdConexion().Close();
            return tblDatos;
        }

        //Ejecuta consulta Select de forma Conectada y retorna DataReader 
        public DataTable mtdSelecConec(string consulta)
        {
            ClConexion objConexion = new ClConexion();
            //objConexion.mtdConexion().Open();
            SqlCommand comando = new SqlCommand(consulta, objConexion.mtdConexion());
            SqlDataReader regis = comando.ExecuteReader();
            DataTable tblprod = new DataTable();
            tblprod.Load(regis);
            objConexion.mtdConexion().Close();
            return tblprod;
        }

        public int mtdIUDconect(string consul)
        {
            ClConexion conexion = new ClConexion();
            SqlCommand comando = new SqlCommand(consul, conexion.mtdConexion());
            int regis = comando.ExecuteNonQuery();
            conexion.mtdConexion().Close();
            return regis;

        }
    }
}