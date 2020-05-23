using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FarmaciasIDS
{
    class Conexion
    {
        SqlConnection cn;

        public SqlConnection getConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source = LAPTOP-REG4TE4S\\SQLEXPRESS;Initial Catalog = BD_MAPAFARMACIA; Integrated Security = True");

                cn.Open();
                return cn;
                //Console.WriteLine("Conectado")
            }
            catch
            {
                // cn.Close();
                return null;
            }
        }

        public SqlConnection CloseConexion()
        {
            try
            {
                // cn = new SqlConnection("Data Source = LAPTOP-REG4TE4S\\SQLEXPRESS;Initial Catalog = BD_MAPAFARMACIA; Integrated Security = True");

                cn.Close();
                return cn;
                //Console.WriteLine("Conectado")
            }
            catch
            {
                return null;
            }
        }

    }
}