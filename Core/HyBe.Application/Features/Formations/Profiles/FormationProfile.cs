using System;
using AutoMapper;
using HyBe.Domain.Contracts.Formations;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Formations;

namespace HyBe.Application.Features.Formations.Profiles;

public class FormationProfile : Profile
{
    public FormationProfile()
    {
        CreateMap<Formation, GetListFormationResponse>().ReverseMap();
        CreateMap<Formation, GetByIdFormationResponse>().ReverseMap();
        CreateMap<CreateFormationRequest, Formation>().ReverseMap();
        CreateMap<UpdateFormationRequest, Formation>().ReverseMap();
    }
}

