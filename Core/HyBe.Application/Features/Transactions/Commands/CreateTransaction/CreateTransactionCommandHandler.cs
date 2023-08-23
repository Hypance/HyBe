using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Transactions.Commands.CreateTransaction;
using HyBe.Domain.Entities.Members;
using HyBe.Domain.Entities.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, HyBe.SharedKernel.Utilities.IResult>
    {
        #region Fields
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<Member> _userManager;
        #endregion

        #region Constructor
        public CreateTransactionCommandHandler(ITransactionService transactionService, IMapper mapper, IHttpContextAccessor contextAccessor, 
            UserManager<Member> userManager)
        {
            _transactionService = transactionService;
            _mapper = mapper;
            _contextAccessor = contextAccessor;
            _userManager = userManager;

        }
        #endregion

        #region Methods
        public async Task<SharedKernel.Utilities.IResult> Handle(CreateTransactionCommand query, CancellationToken cancellationToken)
        {
            
            var transaction = Transaction.Create(query.Request.MemberId, query.Request.Asset,query.Request.Amount,query.Request.Side,query.Request.EntryPrice);
            var result = _transactionService.Add(transaction);
            if (result.Success)
            {
                System.Security.Claims.ClaimsPrincipal currentUser = _contextAccessor.HttpContext.User;
                var claims = currentUser.Claims.ToArray();
                _transactionService.CreateMemberTransactionRelationship(new MemberTransactionRelationship { MemberId = claims[3].Value });

                return new SuccessResult(); 
            }

            return new ErrorResult(result.Message);
        }
        #endregion
    }
}