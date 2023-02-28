using System;
using AutoMapper;
using HyBe.Domain.Contracts.Wallets;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Wallets;

namespace HyBe.Application.Features.Wallets.Profiles;

public class WalletProfile : Profile
{
    public WalletProfile()
    {
        CreateMap<Wallet, GetListWalletResponse>().ReverseMap();
        CreateMap<Wallet, GetByIdWalletResponse>().ReverseMap();
        CreateMap<CreateWalletRequest, Wallet>().ReverseMap();
        CreateMap<UpdateWalletRequest, Wallet>().ReverseMap();
    }
}

