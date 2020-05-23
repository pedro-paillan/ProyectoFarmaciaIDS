using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FarmaciasIDS
{
    public class usuario
    {
        public int id { get; set; }
        public string correo { get; set; }
        public string pass { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }

    public class farmacia
    {
        public int fa_id { get; set; }
        public string fa_nombreFarmacia { get; set; }
        public string fa_cantidasucursales { get; set; }
        public string local_lng { get; set; }
        public string local_lang { get; set; }
        public string local_id { get; set; }
        public string fa_sec_id { get; set; }
    }

    public class farmaciasAPI
    {
        public string help { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
        public int Length { get; set; }

        public class Result
        {
            public IList<Records> records { get; set; }
            public IList<Fields> fields { get; set; }
            public string sql { get; set; }
            public int Length { get; set; }


            public class Fields
            {
                public int Length { get; set; }

                public string type { get; set; }
                public string id { get; set; }

            }

            public class Records
            {
                public int Length { get; set; }
                public string localidad_nombre { get; set; }
                public string local_telefono { get; set; }
                public string comuna_nombre { get; set; }
                public string fecha { get; set; }
                public string _full_text { get; set; }
                public string fk_comuna { get; set; }
                public string local_nombre { get; set; }
                public string funcionamiento_dia { get; set; }
                public string local_id { get; set; }
                public string local_lng { get; set; }
                public string local_lat { get; set; }
                public string funcionamiento_hora_apertura { get; set; }
                public string fk_localidad { get; set; }
                public string fk_region { get; set; }
                public int _id { get; set; }
                public string local_direccion { get; set; }
                public string funcionamiento_hora_cierre { get; set; }
            }

        }

    }
}