using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcpc.Models;

namespace mvcpc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Formulario() {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Formulario formulario){
            // Guardarlo en una BD
            // Enviar un correo
            // No hacer nada
            Console.WriteLine(formulario.NombreCompleto);
            Console.WriteLine(formulario.TipMascota);
            Console.WriteLine(formulario.Descripcion);
            Console.WriteLine(formulario.Telefono);
            Console.WriteLine(formulario.Distrito);
            Console.WriteLine(formulario.Direccion);
            return RedirectToAction("Confirmacion");
            //return View("ContactoConfirmacion");
        }

        public IActionResult Confirmacion(string param1,string mensaje, int n) {
            ViewData["param1"] = n;
            ViewData["mensaje"] = mensaje;
            return View();
        }

        public IActionResult Index()
        {
            //ViewData["param1"] = n;
            //ViewData["mensaje"] = mensaje;
            // return View();
            //return RedirectToAction("Formulario");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
