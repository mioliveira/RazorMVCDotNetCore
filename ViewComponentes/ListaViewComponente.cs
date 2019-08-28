using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMVCDotNetCore.ViewComponentes
{
    [ViewComponent(Name = "Lista")]
    public class ListaViewComponente : ViewComponent
    {
        public List<string> lista {get;set;}
        public ListaViewComponente()
        {
            lista = new List<string>();
            lista.Add("MIRIAN");
            lista.Add("augusto");
            lista.Add("sidnei");
            lista.Add("marco");

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(lista);
        }
    }
}
