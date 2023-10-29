using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Commands.DeleteTransaction
{
    public class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand, IResult>
    {
        #region Fileds
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public DeleteTransactionCommandHandler(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(DeleteTransactionCommand query, CancellationToken cancellationToken)
        {
            var getTransaction = _transactionService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getTransaction.Success == false)
            {
                return new ErrorResult("Data Not Found!");
            }
            var result = _transactionService.Delete(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult(result.Message);
            #endregion
        }
    }
}
