using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using FarmaciasIDS.Models;

namespace FarmaciasIDS.Controllers
{
    public class APIController : Controller
    {
        APIModel api;

        // GET: API
        public ActionResult Index()
        {
            return View();
        }

        // [HttpPost]
        public ActionResult get_List_Farmacias()
        {
            // Create a request using a URL that can receive a post.
            string uri = "http://datos.gob.cl/api/action/datastore_search_sql?sql=SELECT%20*%20from%20%22a60f93af-6a8a-45b6-85ff-267f5dd37ad6%22%20";
            // Set the Method property of the request to POST.
            var request = (HttpWebRequest)WebRequest.Create(uri);

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            farmaciasAPI mi_respuesta = JsonConvert.DeserializeObject<farmaciasAPI>(responseString);

            //ViewData["wrGETURL"] = esto;

            ViewBag.res = Farmacia(mi_respuesta, "insert");
            return RedirectToAction("../Home");

            //return View();
        }

        public ActionResult getSectores()
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

        public bool Farmacia(farmaciasAPI farmaciass, string tipo)
        {

            switch (tipo)
            {
                case "insert":
                    api = new APIModel();

                    farmaciasAPI far;
                    far = (farmaciasAPI)farmaciass;

                    bool v = false;
                    string[] listado = new string[1000];
                    string[] insert = new string[10000];
                    int incrementable = 0;
                    int incrementable1 = 0;

                    for (int i = 0; i < far.result.records.Count(); i++)
                    {
                        bool f = api.farmacia_get(far.result.records[i]._id);// Valida si existe el registro anteriormente

                        if (!f)
                        {
                            v = api.farmacia_insert(far.result.records[i]._id, far.result.records[i].local_nombre, far.result.records[i].local_lat, far.result.records[i].local_lng, far.result.records[i].fk_localidad);
                            if (!v)
                            {
                                listado[incrementable] = far.result.records[i]._id.ToString();//Registeo de las farmacias no creadas.
                                incrementable++;
                            }
                            else
                            {
                                insert[incrementable1] = far.result.records[i]._id.ToString();//Registeo de las farmacias creadas.
                                incrementable1++;
                            }
                        }
                    }

                    if (incrementable1 > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    //return v;

                    break;

                default:
                    string[] listado1 = new string[1000];

                    return false;
                    break;
            }

        }

        public bool Sectores(farmaciasAPI farmaciass, string tipo)
        {

            switch (tipo)
            {
                case "insert":
                    api = new APIModel();

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

    }
}
