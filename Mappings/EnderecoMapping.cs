using AutoMapper;
using IntegraBancosApi.Dtos;
using IntegraBancosApi.Models;

namespace IntegraBancosApi.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, Endereco>();
            CreateMap<Endereco, EnderecoResponse>();
        }
    }
}