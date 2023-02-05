using AutoMapper;
using HyBe.Domain.Contracts.Symbols;
using HyBe.Domain.Entities.Symbols;

namespace HyBe.Application.Features.Symbols.Profiles
{
    public class SymbolProfile : Profile
    {
        public SymbolProfile() 
        {
            CreateMap<Domain.Entities.Symbols.Symbol, GetListSymbolResponse>();
        }  
    }
}
