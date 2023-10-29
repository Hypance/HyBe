using HyBe.Domain.Contracts.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Commands.DeleteTransaction
{
    public class DeleteTransactionCommand : IRequest<IResult>
    {
        public DeleteTransactionRequest Request { get; set; }
        public string MemberId { get; set; }
        public DeleteTransactionCommand(DeleteTransactionRequest request)
        {
            Request = request;
        }
    }
}
