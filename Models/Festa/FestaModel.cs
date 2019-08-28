using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMVCDotNetCore.Models.Festa
{
    public class FestaModel
    {
        public long Codigo { get; set; }
        public string Endereco { get; set; }
        public DateTime DtHorarioInicio { get; set; }
        public DateTime DtHorarioFinal { get; set; }
        public long NumConvidados { get; set; }
        public decimal VlrDesconto { get; set; }
        public decimal VlrTotal { get; set; }
        public long CodCliente { get; set; }
        public long CodTema { get; set; }
    }
}
