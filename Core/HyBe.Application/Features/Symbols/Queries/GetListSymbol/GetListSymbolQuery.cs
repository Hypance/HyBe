using HyBe.Domain.Contracts.Symbols;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Symbols.Queries.GetListSymbol;

public class GetListSymbolQuery : IRequest<IResult>
{
    public GetListSymbolRequest Request { get; set; }
    public GetListSymbolQuery(GetListSymbolRequest request)
    {
        Request = request;
    }
}

