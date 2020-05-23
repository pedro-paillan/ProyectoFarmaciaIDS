using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmaciasIDS.Models;
using Newtonsoft.Json;


namespace FarmaciasIDS.Controllers
{
    public class FarmaciasController : Controller
    {
        FarmaciasModel farmacias;

        // GET: Farmacias
        public ActionResult Index()
        {
            return View();
        }

        // GET: Farmacias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public JsonResult getListado()
        {
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            farmacias = new FarmaciasModel();

            DataTable data = new DataTable();
            
            data = farmacias.getListado();

            List<string[]> myTable = new List<string[]>();
            string[] myTableRow = new string[data.Columns.Count];


            int filas = 0;
            foreach (DataRow dr in data.Rows)
            {
                string[] arr = new string[7];

                arr[0] = data.Rows[filas]["fa_id"].ToString();
                arr[1] = data.Rows[filas]["fa_nombreFarmacia"].ToString();
                arr[2] = data.Rows[filas]["local_lng"].ToString();
                arr[3] = data.Rows[filas]["local_lang"].ToString();
                arr[4] = data.Rows[filas]["sec_nombre"].ToString();

                myTable.Add(arr);
                // myTable.Add(myTableRow);
                filas++;
            }
            var table2DArray = myTable;




           // var result = JsonConvert.SerializeObject(data, Formatting.Indented).Replace(" ", "");
            //var json_data = result.Replace("\n", "");
            var json_request = Json(new { data = table2DArray, count = data.Rows.Count });

            //return Json(new { data = JsonConvert.SerializeObject(data,Formatting.Indented), count = data.Rows.Count });
            return json_request;
        }

        // GET: Farmacias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmacias/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Farmacias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Farmacias/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Farmacias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Farmacias/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
