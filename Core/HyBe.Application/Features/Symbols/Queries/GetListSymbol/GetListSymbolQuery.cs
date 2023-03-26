using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Queries.GetListSymbol
{
    public class GetListSymbolQuery : IRequest<IResult>
    {
        public GetListSymbolRequest Request { get; set; }

        public GetListSymbolQuery(GetListSymbolRequest request)
        {
            Request = request;
        }
    }
}
