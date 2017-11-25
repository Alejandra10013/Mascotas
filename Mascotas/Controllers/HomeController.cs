using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mascotas.Models;

namespace Mascotas.Controllers
{
    public class HomeController : Controller
    {
        List<Mascota> listado = new List<Mascota>();

        public HomeController() {

            listado.Add(new Mascota() { codigo = 1, nombre = "Jack", propietario = "Karina Cardenas", edad = 10, raza = "Golden" });
            listado.Add(new Mascota() { codigo = 2, nombre = "Toby", propietario = "Karina Cardenas", edad = 9, raza = "kiltro" });

        }
        public IActionResult Mantenedor()
        {

            return View(new Mascota());
        }

        public IActionResult Listado()
        {

            return View(listado);
        }
        public IActionResult Ficha(int codigo, string nombre, string raza, string propietario, int edad)
        {
            Mascota nueva = new Mascota() {
            codigo = codigo,
            nombre = nombre,
            raza = raza,
            propietario = propietario,
            edad = edad

        };
            return View(nueva);
        }

    }
}
