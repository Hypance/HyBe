using HyBe.Domain.Entities.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using System.Threading.Tasks;
using HyBe.Domain.Contracts.Symbols;

namespace HyBe.Application.Features.Symbols.Profiles
{
    public class SymbolProfile : Profile
    {
        public SymbolProfile()
        {
            CreateMap<Symbol, GetListSymbolResponse>().ReverseMap();
            CreateMap<Symbol, GetByIdSymbolResponse>().ReverseMap();
            CreateMap<CreateSymbolRequest, Symbol>().ReverseMap();
            CreateMap<UpdateSymbolRequest, Symbol>().ReverseMap();
        }
    }
}
