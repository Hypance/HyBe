using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Wallets;

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
            var bot = _walletService.Get(x => x.Id == query.Request.Id);
            var getBacktest = _walletService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getBacktest == null)
            {
                return new ErrorResult("Data Not Found!");
            }
            if (!bot.Success)
                return new ErrorResult();
            var result = _walletService.Update(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
        }
    }
}
