using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Symbols.Commands.DeleteSymbol
{
    public class DeleteSymbolCommand : IRequest<IResult>
    {
        public DeleteSymbolRequest Request { get; set; }
        public string MemberId { get; set; }

        public DeleteSymbolCommand(DeleteSymbolRequest request)
        {
            Request = request;
        }
    }

}
