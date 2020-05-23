using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FarmaciasIDS.Models
{
    public class LoginModel
    {

        SqlCommand cmd;
        SqlDataReader dr;
        usuario user;

        public usuario getDataUsuario(string correo, string pass)
        {
            Conexion c = new Conexion();
            user = new usuario();

            try
            {
                string query = "SELECT * FROM usu_usuario WHERE usu_correo = '" + correo + "' AND usu_password = '" + pass + "'";
                cmd = new SqlCommand(query, c.getConexion());
                SqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    var total = reader.HasRows;
                    // c.CloseConexion();
                    if (total)
                    {
                        while (reader.Read())
                        {
                            user.nombre = reader.GetString(1);
                            user.apellido = reader.GetString(2);
                            user.correo = reader.GetString(3);
                            user.id = reader.GetInt32(0);
                        }
                        return user;
                    }
                    else
                    {
                        return user;
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
                c.CloseConexion();
                return user;
            }
        }

        public bool usuario_insert(string name, string apellido, string correo, string pass)
        {
            Conexion c = new Conexion();
            try
            {
                string query = "INSERT INTO usu_usuario (usu_nombre,usu_apellido,usu_correo,usu_password) VALUES ('" + name + "','" + apellido + "','" + correo + "','" + pass + "');";
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
    }
}