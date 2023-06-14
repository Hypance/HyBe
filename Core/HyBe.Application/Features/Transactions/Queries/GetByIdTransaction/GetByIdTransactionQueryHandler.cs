using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Queries.GetByIdTransaction
{
    public class GetByIdTransactionQueryHandler : IRequestHandler<GetByIdTransactionQuery, IResult>
    {
        #region Fileds
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetByIdTransactionQueryHandler(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(GetByIdTransactionQuery query, CancellationToken cancellationToken)
        {

            var result = _transactionService.Get(b => b.Id == query.Request.Id);
            if (result.Success)
            {
                var transactionMapper = _mapper.Map<GetByIdTransactionResponse>(result.Data);
                return new SuccessDataResult<GetByIdTransactionResponse>(transactionMapper);
            }
            return new ErrorDataResult<GetByIdTransactionResponse>(result.Message);
        }
        #endregion
    }
}
