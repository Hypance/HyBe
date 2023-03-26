using System;
using HyBe.Domain.Contracts.Bots;
using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Wallets.Commands;

public class CreateWalletCommand : IRequest<IResult>
{
    public CreateWalletRequest Request { get; set; }

    public CreateWalletCommand(CreateWalletRequest request)
    {
        Request = request;
    }
}
