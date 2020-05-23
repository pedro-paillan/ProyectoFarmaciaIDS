using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FarmaciasIDS.Models
{
    public class APIModel
    {

        SqlCommand cmd;
        SqlDataReader dr;

        public bool farmacia_insert(int _id, string name, string log, string lat, string fa_sec_id)
        {
            int result = Int32.Parse(fa_sec_id);
            Conexion c = new Conexion();

            try
            {
                string query = "INSERT INTO fa_farmacia (fa_nombreFarmacia,fa_cantidasucursales,local_lng,local_lang,local_id,fa_sec_id) VALUES ('" + name + "','1','" + log + "','" + lat + "','" + _id + "'," + result + ");";
                cmd = new SqlCommand(query, c.getConexion());
                int n = cmd.ExecuteNonQuery();
                c.CloseConexion();

                return n > 0;

            }
            catch
            {
                c.CloseConexion();
                return false;
            }


        }

        public bool farmacia_get(int _id)
        {

            try
            {
                Conexion c = new Conexion();
                string query = "SELECT * FROM fa_farmacia WHERE local_id = " + _id + ";";
                cmd = new SqlCommand(query, c.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    var total = reader.HasRows;
                    c.CloseConexion();
                    if (total)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            catch
            {
                return false;
            }


        }

        public bool sector_insert(string name, string fk_localidad, string fk_region)
        {

            try
            {
                Conexion c = new Conexion();
                string query = "INSERT INTO sec_sector (sec_nombre,fk_localidad,fk_region) VALUES ('" + name + "', '" + fk_localidad + "', '" + fk_region + "');";
                cmd = new SqlCommand(query, c.getConexion());
                int n = cmd.ExecuteNonQuery();

                c.CloseConexion();

                return n > 0;

            }
            catch
            {
                return false;
            }
        }

        public bool sector_get(string fk_localidad)
        {

            try
            {
                Conexion c = new Conexion();
                string query = "SELECT * FROM sec_sector WHERE fk_localidad = '" + fk_localidad + "';";
                cmd = new SqlCommand(query, c.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    var total = reader.HasRows;
                    if (total)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                    c.CloseConexion();
                }
            }
            catch
            {
                return false;
            }

        }

    }
}
