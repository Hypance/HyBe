using System;
using AutoMapper;
using HyBe.Domain.Contracts.Bots;
using HyBe.Domain.Entities.Bots; 

namespace HyBe.Application.Features.Backtests.Profiles;

public class BotProfile : Profile
{
    public BotProfile()
    {
        CreateMap<Domain.Entities.Bots.Bot, GetListBotResponse>();
        CreateMap<Domain.Entities.Bots.Bot, GetByIdBotResponse>();
        CreateMap<CreateBotRequest, Domain.Entities.Bots.Bot>();
        CreateMap<UpdateBotRequest, Domain.Entities.Bots.Bot>();
    }
}

