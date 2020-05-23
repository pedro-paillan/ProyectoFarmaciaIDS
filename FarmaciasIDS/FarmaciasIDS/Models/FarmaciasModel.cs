using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.UI.WebControls.WebParts;

namespace FarmaciasIDS.Models
{
    public class FarmaciasModel
    {
        SqlCommand cmd;
        SqlDataReader dr;
        farmacia farmacia;

        public DataTable getListado(params string[] filtrado)
        {
            Conexion c = new Conexion();
            farmacia = new farmacia();
            DataTable list_farmacias = new DataTable("fa_farmacia");

            List<Part> farmacias = new List<Part>();

            try
            {
                string query = "SELECT TOP (0|20) far.*, sec.* FROM fa_farmacia far INNER JOIN sec_sector sec ON fa_sec_id = sec_id";
                cmd = new SqlCommand(query, c.getConexion());
                var reader = cmd.ExecuteReader();
                list_farmacias.Load(reader);
                // list_farmacias.Load(reader);

                try
                {
                     return list_farmacias;

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
                c.CloseConexion();
                return list_farmacias;
            }
        }
    }
}