using System;
using AutoMapper;
using HyBe.Domain.Contracts.Bots;
using HyBe.Domain.Entities;

namespace HyBe.Application.Features.Bots.Profiles;

public class BotProfile : Profile
{
    public BotProfile()
    {
        CreateMap<Bot,GetListBotResponse>().ReverseMap();
        CreateMap<Bot,GetByIdBotResponse>().ReverseMap();
        CreateMap<CreateBotRequest,Bot>().ReverseMap();
        CreateMap<UpdateBotRequest,Bot>().ReverseMap();
    }
}

