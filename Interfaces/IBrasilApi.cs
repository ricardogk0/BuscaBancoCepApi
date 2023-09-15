using IntegraBancosApi.Dtos;
using IntegraBancosApi.Models;

namespace IntegraBancosApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<Endereco>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<Banco>>> BuscarTodosBancos();
        Task<ResponseGenerico<Banco>> BuscarBanco(string codigoBanco);
    }
}