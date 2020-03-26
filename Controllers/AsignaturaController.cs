using System;
using System.Collections.Generic;
using CursoASPNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoASPNetCore.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura(){
                Nombre = "Programacion",
                UniqueId = Guid.NewGuid().ToString()
            };

            return View(asignatura);
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                new Asignatura{Nombre="Matematicas", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Educacion Fisica", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Castellano", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ciencias Naturales", UniqueId = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Programacion", UniqueId = Guid.NewGuid().ToString()}
            };

            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}