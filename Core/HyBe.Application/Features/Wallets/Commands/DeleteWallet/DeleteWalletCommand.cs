using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;


namespace HyBe.Application.Features.Wallets.Commands.DeleteWallet
{
    public class DeleteWalletCommand : IRequest<IResult>
    {
        public DeleteWalletRequest Request { get; set; }
        public string MemberId { get; set; }

        public DeleteWalletCommand(DeleteWalletRequest request)
        {
            Request = request;
        }
    }
}
