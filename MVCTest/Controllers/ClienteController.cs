using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AltaCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AltaCliente(Cliente cliente)
        {
            return RedirectToAction("Index");
        }

        public IActionResult ConsultaCliente()
        {
            Cliente miCliente = new Cliente();
            miCliente.Edad = 37;
            miCliente.Name = "exequiel";
            return View(miCliente);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}