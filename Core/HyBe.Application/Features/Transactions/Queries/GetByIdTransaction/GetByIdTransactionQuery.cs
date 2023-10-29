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
    public class GetByIdTransactionQuery : IRequest<IResult>
    {
        public GetByIdTransactionRequest Request { get; set; }

        public GetByIdTransactionQuery(GetByIdTransactionRequest request)
        {
            Request = request;
        }
    }
}
