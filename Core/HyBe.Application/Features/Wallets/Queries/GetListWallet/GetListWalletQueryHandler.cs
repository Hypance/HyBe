using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Wallets.Commands.UpdateWallet;
using HyBe.Application.Features.Wallets.Queries;
using HyBe.Application.Features.Wallets.Queries.GetByIdWallet;
using HyBe.Domain.Contracts.Wallets;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Wallets.Queries.GetListWallet
{
    public class GetListWalletQueryHandler : IRequestHandler<GetListWalletQuery, IResult>
    {

        private readonly IWalletService _walletService;
        private readonly IMapper _mapper;
        public GetListWalletQueryHandler(IWalletService walletService, IMapper mapper)
        {
            _walletService = walletService;
            _mapper = mapper;
        }
        public async Task<IResult> Handle(GetListWalletQuery query, CancellationToken cancellationToken)
        {

            var result = _walletService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
            if (result.Success)
            {
                var walletMapper = _mapper.Map<List<GetListWalletResponse>>(result.Data);
                return new SuccessDataResult<List<GetListWalletResponse>>(walletMapper);
            }
            return new ErrorDataResult<List<GetListWalletResponse>>(result.Message);
        }
    }
}
