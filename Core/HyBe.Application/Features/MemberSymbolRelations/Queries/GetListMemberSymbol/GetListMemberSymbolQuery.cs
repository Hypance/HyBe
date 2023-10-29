using HyBe.Domain.Contracts.MemberSymbols;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.MemberSymbolRelations.Queries.GetListMemberSymbol;
public class GetListMemberSymbolQuery : IRequest<IResult>
{
    public GetListMemberSymbolRequest Request { get; set; }

    public GetListMemberSymbolQuery(GetListMemberSymbolRequest request)
    {
        Request = request;
    }
}