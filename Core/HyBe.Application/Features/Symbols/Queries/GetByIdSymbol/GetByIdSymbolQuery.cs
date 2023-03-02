using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Queries.GetByIdSymbol
{
    public class GetByIdSymbolQuery : IRequest<IResult>
    {
        public GetByIdSymbolRequest Request { get; set; }

        public GetByIdSymbolQuery(GetByIdSymbolRequest request)
        {
            Request = request;
        }
    }

}
