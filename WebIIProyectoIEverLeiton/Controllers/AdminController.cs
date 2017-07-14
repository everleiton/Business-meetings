using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebIIProyectoIEverLeiton.Models;

namespace WebIIProyectoIEverLeiton.Controllers
{
    public class AdminController : Controller
    {
        private DBContext db = new DBContext();
        // GET: Admin
        public ActionResult Index()
        {

            // return View(db.Database.SqlQuery<Usuario>("select Usuarios.IdUsuario, Usuarios.Nombre, Usuarios.Apellidos, Usuarios.Correo,Usuarios.Telefono, Usuarios.Puesto , Usuarios.Rol, Clientes.IdCliente as FkIdCliente from Usuarios Join  Clientes on Usuarios.FkIdCliente_IdCliente = Clientes.IdCliente").ToList<Usuario>());
            return View(db.Usuario.ToList());

        }
        public ActionResult LogAdmin()
        {
            return View();
        }
        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario user = db.Usuario.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {

            int a = 0;
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var cliente in db.Cliente.ToList())
            {
                items.Add(new SelectListItem { Text = cliente.Nombre, Value = a.ToString() });
                a++;
            }

            ViewBag.Cliente_al_que_pertenece = items;

            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "IdUsuario,IdCliente,Nombre,Apellidos,Correo,Telefono,Puesto,Contrasena,Rol, Cliente_al_que_pertenece")] Usuario user)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Usuario.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");



            }
            catch
            {
                return View();
            }
        }





        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario user = db.Usuario.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "IdUsuario,IdCliente,Nombre,Apellidos,Correo,Telefono,Puesto,Rol")] Usuario user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario user = db.Usuario.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db = new DBContext();
                
                db.Database.SqlQuery<Usuario>("delete  from Usuarios where Usuarios.IdUsuario =" + id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
