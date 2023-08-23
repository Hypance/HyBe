using HyBe.Domain.Contracts.Transactions;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Transactions.Queries.GetListTransaction
{
    public class GetListTransactionQuery : IRequest<IResult>
    {
        public GetListTransactionRequest Request { get; set; }
        public object MemberId { get; internal set; }

        public GetListTransactionQuery(GetListTransactionRequest request)
        {
            Request = request;
        }
    }
}
