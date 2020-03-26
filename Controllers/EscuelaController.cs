using System;
using CursoASPNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoASPNetCore.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Guatemala";
            escuela.Pais = "Guatemala";
            escuela.Dirección = "Zona 16";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //ViewBag es una vista similar a ViewData, nos sirve para crear variables dinamicas.
            ViewBag.CosaDinamica = "La monja";

            return View(escuela);
        }
    }
}