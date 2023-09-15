using IntegraBancosApi.Dtos;

namespace IntegraBancosApi.Interfaces
{
    public interface IBancoSerice
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}