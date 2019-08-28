using RazorMVCDotNetCore.Models.Festa;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorMVCDotNetCore.Models.Clientes
{
    public class ClienteModel
    {
        [Display(Name = "Código")]
        public int Codigo { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage ="O campo 'Nome' é obrigatório.")]
        [StringLength(80, MinimumLength =3, ErrorMessage ="o campo 'Nome' deve ter entre 3 e 60 caracteres.")]
        public string Nome { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo 'Telefone' é obrigatório.")]
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O campo 'Endereço' é obrigatório.")]
        public string Endereco { get; set; }
        [Display(Name = "Locações")]
        public List<FestaModel> Locacoes { get; set; }

        public ClienteModel()
        {
            Locacoes = new List<FestaModel>();
        }
    }
}