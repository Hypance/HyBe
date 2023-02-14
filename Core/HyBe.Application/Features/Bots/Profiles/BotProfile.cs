using System;
using AutoMapper;
using HyBe.Domain.Contracts.Bots;
using HyBe.Domain.Entities;

namespace HyBe.Application.Features.Backtests.Profiles;

public class BotProfile : Profile
{
    public BotProfile()
    {
        CreateMap< Bot, GetListBotResponse>();
        CreateMap< Bot, GetByIdBotResponse>();
        CreateMap<CreateBotRequest,  Bot>();
        CreateMap<UpdateBotRequest,  Bot>();
    }
}

