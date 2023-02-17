using System;
using HyBe.Domain.Contracts.FormationSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.FormationSignals.Queries;

public class GetListFormationSignalQuery : IRequest<IResult>
{
    public GetListFormationSignalRequest Request { get; set; }

    public GetListFormationSignalQuery(GetListFormationSignalRequest request)
    {
        Request = request;
    }
}

