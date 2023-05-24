using Microsoft.AspNetCore.Mvc;
using POOII_CL1_QUISPE_EDSON.Models;

namespace POOII_CL1_QUISPE_EDSON.Controllers
{
    public class ProductoController : Controller
    {
        BDProducto bdp = new BDProducto();
        public IActionResult Inicio()
        {
			List<Producto> listaProducto = bdp.ObtenerTodos();
			return View(listaProducto);
		}

        public IActionResult ProductosPorDescripcion(string descripcion)
        {
            List<Producto> listaProducto = bdp.ProductosPorDescripcion(descripcion);
            return View(listaProducto);
        }

        public IActionResult ProductosPorPrecio (decimal precioMin, decimal precioMax)
        {
            List<Producto> listaProducto = bdp.ProductosPorPrecio(precioMin, precioMax);
            return View(listaProducto);
        }

        public IActionResult ProductosPorTipoYPrecio(string tipo, decimal precio)
        {
            List<Producto> listaProducto = bdp.ProductosPorTipoYPrecio(tipo, precio);
            return View(listaProducto);
        }
    }
}
