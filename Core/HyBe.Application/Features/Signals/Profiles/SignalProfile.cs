using System;
using AutoMapper;
using HyBe.Domain.Contracts.Signals;
using HyBe.Domain.Entities.Signals;

namespace HyBe.Application.Features.Signals.Profiles;

public class SignalProfile : Profile
{
	public SignalProfile()
	{
        CreateMap<GetListSignalResponse, Signal>().ReverseMap();
        CreateMap<GetByIdSignalResponse, Signal>().ReverseMap();
        CreateMap<Signal, CreateSignalRequest>().ReverseMap();
        CreateMap<Signal, UpdateSignalRequest>().ReverseMap();
    }
}

