using Microsoft.AspNetCore.Mvc;
using RazorMVCDotNetCore.Data.Interface;
using RazorMVCDotNetCore.Models.Clientes;

namespace RazorMVCDotNetCore.Controllers
{
    public class ClienteController : Controller
    {
       private readonly ICliente _clienteReporytory;
        public ClienteController(ICliente clienteReporytory)
        {
            _clienteReporytory = clienteReporytory;
        }

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
                _clienteReporytory.Cadastrar(cliente);
            }
            return View("Lista");
        }

        [HttpGet]
        public IActionResult Lista()
        {
            return View(_clienteReporytory.RetornarCliente(1));
        }
    }
}