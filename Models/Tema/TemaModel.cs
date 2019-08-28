using RazorMVCDotNetCore.Models.Artigo;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorMVCDotNetCore.Models.Tema
{
    public class TemaModel
    {
        [Display(Name ="Código")]
        public long Codigo { get; set; }
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Artigos")]
        public List<ArtigoTemaModel> Artigos { get; set; }

        public TemaModel()
        {
            Artigos = new List<ArtigoTemaModel>();
        }
    }
}
