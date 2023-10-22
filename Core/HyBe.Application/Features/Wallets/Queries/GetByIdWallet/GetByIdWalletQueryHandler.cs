using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Wallets.Commands.DeleteWallet;
using HyBe.Domain.Contracts.Transactions;
using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Wallets.Queries.GetByIdWallet
{
    public class GetByIdWalletQueryHandler : IRequestHandler<GetByIdWalletQuery, IResult>
    {
        private readonly IWalletService _walletService;
        private readonly IMapper _mapper;
        public GetByIdWalletQueryHandler(IWalletService walletService, IMapper mapper)
        {
            _walletService = walletService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(GetByIdWalletQuery query, CancellationToken cancellationToken)
        {

            var result = _walletService.Get(b => b.MemberId.ToString() == query.Request.MemberId && b.Id == query.Request.Id);
            if (result.Success)
            {
                var walletMapper = _mapper.Map<GetByIdWalletResponse>(result.Data);
                return new SuccessDataResult<GetByIdWalletResponse>(walletMapper);
            }
            return new ErrorDataResult<GetByIdWalletResponse>(result.Message);
        }
    }
}
