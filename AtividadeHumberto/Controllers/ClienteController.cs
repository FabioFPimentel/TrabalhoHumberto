using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AtividadeHumberto.ClienteDAL;
using AtividadeHumberto.ICliente;
using AtividadeHumberto.Models;

namespace AtividadeHumberto.Controllers
{
    public class ClienteController : Controller
    {
        private InterCliente IICliente;
        public ClienteController(InterCliente IIICliente)
        {
            IICliente = IIICliente;
        }
        public IActionResult Index(int id)
        {
            var auxiliar = IICliente.Create(id);
            return View(auxiliar);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente cCliente)
        {
            IICliente.Insert(cCliente);
            return View();
        }
        public IActionResult Edit(int id)
        {
            return View(IICliente.Create(id));
        }
        [HttpPost]
        public IActionResult Edit(Cliente cCliente)
        {
            IICliente.Update(cCliente);
            return View();
        }
    }
}