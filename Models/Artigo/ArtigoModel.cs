using System.ComponentModel.DataAnnotations;

namespace RazorMVCDotNetCore.Models.Artigo
{
    public class ArtigoModel
    {
        [Display(Name = "Código")]
        public long Codigo { get; set; }
        [Display(Name ="Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Cor")]
        public string Cor { get; set; }
        [Display(Name = "Tamanho")]
        public string Tamanho { get; set; }
        [Display(Name = "Quantidade (Pacote)")]
        public int Qtd { get; set; }
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }
    }
}
