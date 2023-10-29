using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Wallets;
using HyBe.Domain.Entities.Backtests;

namespace HyBe.Application.Features.Wallets.Commands.UpdateWallet
{
    public class UpdateWalletCommandHandler : IRequestHandler<UpdateWalletCommand, IResult>
    {
        private readonly IWalletService _walletService;
        private readonly IMapper _mapper;
        public UpdateWalletCommandHandler(IWalletService walletService, IMapper mapper)
        {
            _walletService = walletService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(UpdateWalletCommand query, CancellationToken cancellationToken)
        {
            var getWallet = _walletService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getWallet == null)
            {
                return new ErrorResult("Data Not Found!");
            }
            var walletMapper = _mapper.Map<Wallet>(query.Request);
            var result = _walletService.Update(walletMapper);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
    }
}
