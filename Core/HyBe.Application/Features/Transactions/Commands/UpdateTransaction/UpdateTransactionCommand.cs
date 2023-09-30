using HyBe.Domain.Contracts.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Commands.UpdateTransaction
{
    public class UpdateTransactionCommand : IRequest<IResult>
    {
        public UpdateTransactionRequest Request { get; set; }
        public string MemberId { get; internal set; }

        public UpdateTransactionCommand(UpdateTransactionRequest request)
        {
            Request = request;
        }
    }
}
