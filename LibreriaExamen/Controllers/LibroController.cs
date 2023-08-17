using LibreriaExamen.Datos;
using LibreriaExamen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibreriaExamen.Controllers
{
    public class LibroController : Controller
    {
        /*LibroDatos _libro=new LibroDatos();
        AutorDatos _autor=new AutorDatos();
        EditorialDatos _editorial=new EditorialDatos();*/
        public IActionResult Listar()
        {
            return View();
        }
        public IActionResult Guardar()
        {
            /*Para mostar los elementos del select*/
            /*List<T> listaA= _autor.Listar();
            List<SelectListItem> listaAs = listaA.ConvertAll(
                item => new SelectListItem()
                {
                    Text = item.NombreAutor.ToString(),
                    Value= item.IdAutor.ToString(),
                    Selected = false
                }) ;
            ViewBag.ListaA = listaAs;*/

            

            return View();
        }
        [HttpPost]
        public IActionResult Guardar(T model)
        {
            
                return View();
            
            
        }
        public IActionResult Editar(int IdLibro)
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Editar()
        {
            
                return View();
            
        }
        public IActionResult Eliminar(int IdLibro)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Eliminar()
        {
            
                return View();
            
        }
    }
}
