using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities;
using HyBe.Domain.Entities.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Commands.UpdateTransaction
{
    public class UpdateTransactionCommandHandler : IRequestHandler<UpdateTransactionCommand, IResult>
    {
        #region Fields
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public UpdateTransactionCommandHandler(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IResult> Handle(UpdateTransactionCommand query, CancellationToken cancellationToken)
        {
            var bot = _transactionService.Get(x => x.Id == query.Request.Id);
            var getBacktest = _transactionService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
            if (getBacktest == null)
            {
                return new ErrorResult("Data Not Found!");
            }
            if (!bot.Success)
                return new ErrorResult();
            var result = _transactionService.Update(query.Request.Id);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();
           /* var transaction = _transactionService.Get(x => x.Id == query.Request.Id);
            if (!transaction.Success)
                return new ErrorResult();
            transaction.Data.CloseTransaction(query.Request.ExitPrice);
            var result = _transactionService.Update(transaction.Data);
            if (result.Success)
                return new SuccessResult();
            return new ErrorResult();*/
        }
        #endregion
    }
}
