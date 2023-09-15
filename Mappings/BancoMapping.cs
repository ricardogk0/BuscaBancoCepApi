using AutoMapper;
using IntegraBancosApi.Dtos;
using IntegraBancosApi.Models;

namespace IntegraBancosApi.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, Banco>();
            CreateMap<Banco, BancoResponse>();
        }
        
    }
}