using System;
using AutoMapper;
using HyBe.Domain.Contracts.Enums;
using HyBe.Domain.Entities.Enums;

namespace HyBe.Application.Features.Enums.Profiles;

public class EnumProfile : Profile
{
    public EnumProfile()
    {
        CreateMap<Enum, GetListEnumResponse>().ReverseMap();
        CreateMap<Enum, GetListEnumResponse>().ReverseMap();
        CreateMap<CreateEnumRequest, Enum>().ReverseMap();
        CreateMap<UpdateEnumRequest, Enum>().ReverseMap();
    }
}

