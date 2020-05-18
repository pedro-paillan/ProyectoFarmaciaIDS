using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProyectoFarmaciaI.Models;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Configuration;
using System.Drawing.Imaging;
using Newtonsoft.Json;
using Microsoft.AspNetCore.JsonPatch.Internal;

namespace ProyectoFarmaciaI.Controllers
{
    public class APIController : Controller
    {

        APIViewModel api;

        // [HttpPost]
        public IActionResult Index()
        {
            // Create a request using a URL that can receive a post.
            string uri = "http://datos.gob.cl/api/action/datastore_search_sql?sql=SELECT%20*%20from%20%22a60f93af-6a8a-45b6-85ff-267f5dd37ad6%22%20";
            // Set the Method property of the request to POST.
            var request = (HttpWebRequest)WebRequest.Create(uri);

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            farmaciasAPI esto = JsonConvert.DeserializeObject<farmaciasAPI>(responseString);

            //ViewData["wrGETURL"] = esto;




            ViewData["wrGETURL"]  = Farmacia(esto, "insert");
            
            return View();
        }

        public IActionResult getSectores()
        {
            // Create a request using a URL that can receive a post.
            string uri = "http://datos.gob.cl/api/action/datastore_search_sql?sql=SELECT%20localidad_nombre,fk_localidad,fk_region%20from%20%22a60f93af-6a8a-45b6-85ff-267f5dd37ad6%22%20";
            // Set the Method property of the request to POST.
            var request = (HttpWebRequest)WebRequest.Create(uri);

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            farmaciasAPI esto = JsonConvert.DeserializeObject<farmaciasAPI>(responseString);

            ViewData["Data_insert"] = responseString;


            Sectores(esto, "insert");

            return View();
        }


        public string[] Farmacia(farmaciasAPI farmaciass, string tipo)
        {

            switch (tipo)
            {
                case "insert":
                        api = new APIViewModel();

                        //farmaciass esto = new farmaciass();
                        farmaciasAPI far;
                        far = (farmaciasAPI)farmaciass;

                        bool v = false;
                        string[] listado = new string[1000];
                        int no_in = 0;

                    for (int i = 0; i < far.result.records.Count(); i++)
                    {
                        bool f = api.farmacia_get(far.result.records[i]._id);

                        if (!f)
                        {
                            v = api.farmacia_insert(far.result.records[i]._id, far.result.records[i].local_nombre, far.result.records[i].local_lat, far.result.records[i].local_lng, far.result.records[i].fk_localidad);
                            if (!v)
                            {
                                listado[no_in] = far.result.records[i]._id.ToString();
                                no_in++;
                            }
                        }
                    }

                    return listado;

                    break;
                
                default:
                    string[] listado1 = new string[1000];

                    return listado1;
                    break;
            }

        }

        public bool Sectores(farmaciasAPI farmaciass, string tipo)
        {

            switch (tipo)
            {
                case "insert":
                    api = new APIViewModel();

                    //farmaciass esto = new farmaciass();
                    farmaciasAPI far;
                    far = (farmaciasAPI)farmaciass;

                    bool v = false;

                    for (int i = 0; i < far.result.records.Count(); i++)
                    {
                        bool e = api.sector_get(far.result.records[i].fk_localidad);
                        if (!e)
                        {
                            v = api.sector_insert(far.result.records[i].localidad_nombre, far.result.records[i].fk_localidad, far.result.records[i].fk_region);

                        }
                    }

                    return v;

                    break;
                case "update":
                    Console.WriteLine("Case 2");
                    return false;
                    break;
                default:
                    Console.WriteLine("Default case");
                    return false;

                    break;
            }

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


        // public ActionResult mas_adelante()
        // {
        //     var clientes = db.Clientes.ToList();
        //     var IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
        //     if (Convert.ToInt32(Session["IdRol"]) != 2 || Convert.ToInt32(Session["IdRol"]) != 7)
        //     {
        //         clientes = (from uc in db.Usuarios_Clientes
        //                     join cc in db.Clientes on uc.IdCliente equals cc.IdCliente
        //                     join us in db.Usuarios on uc.IdUsuario equals us.IdUsuario
        //                     where uc.IdUsuario == IdUsuario
        //                     select cc).ToList();
        //     }


        //     // clientes = clientes.Where(x => x.IdUsuario == IdUsuario).ToList();
        //     return View(clientes.OrderBy(x => x.RazonSocial));
        // }

        
    }
}
