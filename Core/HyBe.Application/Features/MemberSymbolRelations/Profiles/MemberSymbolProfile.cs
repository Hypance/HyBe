using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Domain.Contracts.MemberSymbols;
using HyBe.Domain.Entities.Members;

namespace HyBe.Application.Features.MemberSymbolRelations.Profiles;
public class MemberSymbolProfile : Profile
{
    public MemberSymbolProfile()
    {
        CreateMap<MemberSymbol, GetListMemberSymbolResponse>();
        CreateMap<CreateMemberSymbolRequest, MemberSymbol>();
    }
}