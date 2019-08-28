using RazorMVCDotNetCore.Data.Interface;
using RazorMVCDotNetCore.Models.Clientes;
using System.Collections.Generic;
using System.Linq;

namespace RazorMVCDotNetCore.Data.Cliente
{
    public class ClienteRepository: ICliente
    {
        private List<ClienteModel> listaCliente { get; set; }

        public ClienteRepository()
        {
            if (listaCliente == null)
                listaCliente = new List<ClienteModel>();
        }
        public int Cadastrar(ClienteModel cliente)
        {
            if (listaCliente.Where(c => c.Nome == cliente.Nome &&
             c.Endereco == cliente.Endereco &&
             c.Telefone == cliente.Telefone).Count() > 0)
                return 0;

            cliente.Codigo = listaCliente.Count() + 1;
            listaCliente.Add(cliente);
            return 1;
        }

        public ClienteModel RetornarCliente(long CodigoCliente)
        {
            return listaCliente.Where(c => c.Codigo == CodigoCliente).FirstOrDefault();
        }

        public List<ClienteModel> Listar()
        {
            return listaCliente;
        }
    }
}
