using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmaciasIDS.Models;


namespace FarmaciasIDS.Controllers
{
    public class LoginController : Controller
    {
        LoginModel login;
        HomeController Home;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.res = false;
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Action
        [HttpPost]
        public ActionResult LoginAction( usuario user)
        {
            bool acceso = false;

            try
            {
                // TODO: Add insert logic here
                login = new LoginModel();
                usuario nuevo = new usuario();
                Home = new HomeController();
                nuevo = login.getDataUsuario(user.correo, user.pass);

                if (nuevo.id > 0)
                {
                    Session["User"] = true;
                    Session["id"] = nuevo.id;
                    Session["correo"] = nuevo.correo;
                    Session["nombre"] = nuevo.nombre;
                    Session["apellido"] = nuevo.apellido;
                    acceso = true;
                }

                return Json(new { acceso });
                // return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Json(new { acceso });
            }
        }

        public ActionResult createUsuario(usuario user)
        {
            bool create = false;
            try
            {
                // TODO: Add insert logic here
                login = new LoginModel();
                create = login.usuario_insert(user.nombre, user.apellido, user.correo, user.pass);
                return Json(new { create });
                // return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Json(new { create });

            }
        }





        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
