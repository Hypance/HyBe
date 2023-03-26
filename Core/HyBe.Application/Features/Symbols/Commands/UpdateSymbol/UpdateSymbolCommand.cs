using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Commands.UpdateSymbol
{
    public class UpdateSymbolCommand : IRequest<IResult>
    {
        public UpdateSymbolRequest Request { get; set; }

        public UpdateSymbolCommand(UpdateSymbolRequest request)
        {
            Request = request;
        }
    }
}
