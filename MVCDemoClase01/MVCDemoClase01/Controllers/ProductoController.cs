﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemoClase01.Models;

namespace MVCDemoClase01.Controllers
{
    [Route("Productos")]
    public class ProductoController : Controller
    {
        List<Producto> listProducto = new();
        [Route("Lista")]
        // GET: ProductoController
        public ActionResult Index()
        {
            Producto producto = new()
            {
                Id = 1,
                Nombre="Donofrio",
                Tipo="Paneton",
                Precio=25
            };
            Producto producto2 = new()
            {
                Id = 2,
                Nombre = "Mota",
                Tipo = "Paneton",
                Precio = 24
            };
            Producto producto3 = new()
            {
                Id = 3,
                Nombre = "Oreo",
                Tipo = "Galleta",
                Precio = 1
            };
			listProducto.Add(producto);
			listProducto.Add(producto2);
			listProducto.Add(producto3);     
            return View(listProducto);
        }


        public ActionResult listPrueba() {
            return View();


        }

        // GET: ProductoController/Details/5
       [Route("Detalle")]

        public ActionResult Details(int id)
        {
            Producto producto = new()
            {
                Id = 1,
                Nombre = "Donofrio",
                Tipo = "Paneton",
                Precio = 25
            };
            Producto producto2 = new()
            {
                Id = 2,
                Nombre = "Mota",
                Tipo = "Paneton",
                Precio = 24
            };
            Producto producto3 = new()
            {
                Id = 3,
                Nombre = "Oreo",
                Tipo = "Galleta",
                Precio = 1
            };
            listProducto.Add(producto);
            listProducto.Add(producto2);
            listProducto.Add(producto3);
            Producto detailProducto = listProducto.Where(p => p.Id == id).FirstOrDefault();
            return View(detailProducto);
         
        }

        // GET: ProductoController/Create
        [Route("Crear")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto)
        {
            try
            {
				listProducto.Add(producto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Edit/5
        [Route("Editar")]

        public ActionResult Edit(int id)
        {
			Producto producto = new()
			{
				Id = 1,
				Nombre = "Donofrio",
				Tipo = "Paneton",
				Precio = 25
			};
			Producto producto2 = new()
			{
				Id = 2,
				Nombre = "Mota",
				Tipo = "Paneton",
				Precio = 24
			};
			Producto producto3 = new()
			{
				Id = 3,
				Nombre = "Oreo",
				Tipo = "Galleta",
				Precio = 1
			};
			listProducto.Add(producto);
			listProducto.Add(producto2);
			listProducto.Add(producto3);
            Producto detailProducto = listProducto.Where(p =>p.Id==id).FirstOrDefault();

			return View(detailProducto);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Producto producto)
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

        // GET: ProductoController/Delete/5
        [Route("Eliminar")]

        public ActionResult Delete(int id)
        {
            Producto producto = new()
            {
                Id = 1,
                Nombre = "Donofrio",
                Tipo = "Paneton",
                Precio = 25
            };
            Producto producto2 = new()
			{
				Id = 2,
				Nombre = "Mota",
				Tipo = "Paneton",
				Precio = 24
			};
			Producto producto3 = new()
			{
				Id = 3,
				Nombre = "Oreo",
				Tipo = "Galleta",
				Precio = 1
			};
            listProducto.Add(producto);
            listProducto.Add(producto2);
            listProducto.Add(producto3);
            Producto detailProducto = listProducto.Where(p => p.Id == id).FirstOrDefault();

            return View(detailProducto);
        }

        // POST: ProductoController/Delete/5
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
