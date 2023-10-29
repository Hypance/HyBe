using System;
using HyBe.Domain.Contracts.MemberSymbols;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.MemberSymbolRelations.Commands.CreateMemberSymbol;

public class CreateMemberSymbolCommand : IRequest<IResult>
{
    public CreateMemberSymbolRequest Request { get; set; }

    public CreateMemberSymbolCommand(CreateMemberSymbolRequest request)
    {
        Request = request;
    }
}