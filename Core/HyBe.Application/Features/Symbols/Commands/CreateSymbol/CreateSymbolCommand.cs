using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Commands.CreateSymbol
{
    public class CreateSymbolCommand : IRequest<IResult>
    {
        public CreateSymbolRequest Request { get; set; }

        public CreateSymbolCommand(CreateSymbolRequest request)
        {
            Request = request;
        }
    }
}
