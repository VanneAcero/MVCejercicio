using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCejercicio.Controllers
{
    public class UsuariosController : Controller
    {
        List<Usuario> listausuario = new List<Usuario>();
        // GET: UsuariosController
        public ActionResult Index()
        {
                List<Usuario> listausuario = new List<Usuario>();
                Usuario us = new Usuario();
                us.Cedula = "151170536";
                us.Nombre = "Erick";
                us.Apellido = "Paredes";
                us.Direccion = "Quito";
                us.Genero = "Masculino";
                for (int i = 0; i < 10; i++)
                {
                    listausuario.Add(us);
                }
            var datos = listausuario.ToString();
            //HttpContext.Session.SetString("ListaUsuario", "");
            
            return View(listausuario);
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                listausuario.Add(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
