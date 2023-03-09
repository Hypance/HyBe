using System;
using HyBe.Domain.Contracts.Signals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Signals.Queries;

public class GetByIdSignalQuery : IRequest<IResult>
{
    public GetByIdSignalRequest Request { get; set; }

    public GetByIdSignalQuery(GetByIdSignalRequest request)
    {
        Request = request;
    }
}

