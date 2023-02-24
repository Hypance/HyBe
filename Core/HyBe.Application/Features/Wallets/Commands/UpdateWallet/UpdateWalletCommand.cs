using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Wallets.Commands.UpdateWallet
{
    public class UpdateWalletCommand : IRequest<IResult>
    {
        public UpdateWalletRequest Request { get; set; }

        public UpdateWalletCommand(UpdateWalletRequest request)
        {
            Request = request;
        }
    }
}
