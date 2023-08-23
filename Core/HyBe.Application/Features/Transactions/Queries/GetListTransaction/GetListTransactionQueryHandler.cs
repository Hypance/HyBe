using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.Symbols;
using HyBe.Domain.Contracts.Transactions;
using HyBe.Domain.Entities.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Queries.GetListTransaction
{
    public class GetListTransactionQueryHandler : IRequestHandler<GetListTransactionQuery, IResult>
    {
        #region Fields
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public GetListTransactionQueryHandler(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }
        #endregion
        #region Methods
        public async Task<IResult> Handle(GetListTransactionQuery request, CancellationToken cancellationToken)
        {
            var result = _transactionService.GetAll(); 
            if(request.Request.StartDate.HasValue)
            {
                result = _transactionService.GetAll(x => x.StartTime >= request.Request.StartDate);
            }
            if (result.Success)
            {
                var transactionMapper = _mapper.Map<List<GetListTransactionResponse>>(result.Data);
                return new SuccessDataResult<List<GetListTransactionResponse>>(transactionMapper);
            }
            return new ErrorDataResult<List<GetListTransactionResponse>>(result.Message);
        }
        #endregion

    }
}
