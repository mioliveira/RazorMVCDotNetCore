using RazorMVCDotNetCore.Models.Clientes;
using System.Collections.Generic;

namespace RazorMVCDotNetCore.Data.Interface
{
    public interface ICliente
    {
        int Cadastrar(ClienteModel cliente);
        ClienteModel RetornarCliente(long CodigoCliente);
        List<ClienteModel> Listar();
    }
}