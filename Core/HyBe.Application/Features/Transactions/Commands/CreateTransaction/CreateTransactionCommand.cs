using HyBe.Domain.Contracts.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommand : IRequest<IResult>
    {
        public CreateTransactionRequest Request { get; set; }
        public CreateTransactionCommand(CreateTransactionRequest request)
        {
            Request = request;
        }
    }
}
