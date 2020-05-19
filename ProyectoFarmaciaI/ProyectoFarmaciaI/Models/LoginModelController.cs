using app.config;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoFarmaciaI.Models
{
    public class LoginModel
    {

        SqlCommand cmd;
        SqlDataReader dr;

        public bool getDataUsuario(string correo, string pass)
        {
           
            Conexion c = new Conexion();

            try
            {
                string query = "SELECT * FROM usu_usuario WHERE usu_correo '" + correo + "' AND usu_password = '" + pass + "');";
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
                c.CloseConexion();
                return false;
            }


        }

    }
}