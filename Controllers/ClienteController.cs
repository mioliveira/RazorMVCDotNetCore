using Microsoft.AspNetCore.Mvc;
using RazorMVCDotNetCore.Models.Clientes;

namespace RazorMVCDotNetCore.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteModel cliente)
        {
            if(ModelState.IsValid)
            {

            }
            return View("Index", cliente);
        }
    }
}