using System;
using AutoMapper;
using HyBe.Domain.Contracts.FormationSignals;
using HyBe.Domain.Entities.Formations;

namespace HyBe.Application.Features.FormationSignals.Profiles;

public class FormationSignalProfile : Profile
{
    public FormationSignalProfile()
    {
        CreateMap<FormationSignal, GetListFormationSignalResponse>().ReverseMap();
        CreateMap<FormationSignal, GetByIdFormationSignalResponse>().ReverseMap();
        CreateMap<CreateFormationSignalRequest, FormationSignal>().ReverseMap();
        CreateMap<UpdateFormationSignalRequest, FormationSignal>().ReverseMap();
    }
}

