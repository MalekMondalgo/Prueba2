using Microsoft.AspNetCore.Mvc;
using MVCDemoClase01.Models;

namespace MVCDemoClase01.Controllers
{
    public class PersonaController : Controller
    {
        List<Persona> listPersona = new();

        public IActionResult Index()
        {
            Persona persona = new()
            {
                Id = 1,
                Nombre = "Arturo",
                Apellido = "Espinoza",
                Edad = 25
            };
            Persona persona2 = new()
            {
                Id = 2,
                Nombre = "Anthony",
                Apellido = "Padilla",
                Edad = 35
            };
            Persona persona3 = new()
            {
                Id = 3,
                Nombre = "Estefano",
                Apellido = "Cardenas",
                Edad = 45
            };
            listPersona.Add(persona);
            listPersona.Add(persona2);
            listPersona.Add(persona3);
            return View(listPersona);
        }
        public IActionResult Create() {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Persona persona) {
            try
            {
                listPersona.Add(persona);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            Persona persona = new()
            {
                Id = 1,
                Nombre = "Arturo",
                Apellido = "Espinoza",
                Edad = 25
            };
            Persona persona2 = new()
            {
                Id = 2,
                Nombre = "Anthony",
                Apellido = "Padilla",
                Edad = 35
            };
            Persona persona3 = new()
            {
                Id = 3,
                Nombre = "Estefano",
                Apellido = "Cardenas",
                Edad = 45
            };
            listPersona.Add(persona);
            listPersona.Add(persona2);
            listPersona.Add(persona3);
            Persona detailPersona = listPersona.Where(p => p.Id == id).FirstOrDefault();

            return View(detailPersona);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Persona persona)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            Persona persona = new()
            {
                Id = 1,
                Nombre = "Arturo",
                Apellido = "Espinoza",
                Edad = 25
            };
            Persona persona2 = new()
            {
                Id = 2,
                Nombre = "Anthony",
                Apellido = "Padilla",
                Edad = 35
            };
            Persona persona3 = new()
            {
                Id = 3,
                Nombre = "Estefano",
                Apellido = "Cardenas",
                Edad = 45
            };
            listPersona.Add(persona);
            listPersona.Add(persona2);
            listPersona.Add(persona3);
            Persona detailPersona = listPersona.Where(p => p.Id == id).FirstOrDefault();

            return View(detailPersona);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Persona persona)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

    }
}
