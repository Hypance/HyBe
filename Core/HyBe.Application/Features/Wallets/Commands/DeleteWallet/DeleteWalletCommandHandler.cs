using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Wallets.Commands.DeleteWallet;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Wallets.Commands.DeleteWallet
{
    public class DeleteWalletCommandHandler : IRequestHandler<DeleteWalletCommand, IResult>
    {
        private readonly IWalletService _walletService;
        private readonly IMapper _mapper;

        public DeleteWalletCommandHandler(IWalletService walletService, IMapper mapper)
        {
            _walletService = walletService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(DeleteWalletCommand query, CancellationToken cancellationToken)
        {
            var result = _walletService.Delete(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
    }
}
