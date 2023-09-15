using IntegraBancosApi.Dtos;

namespace IntegraBancosApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}