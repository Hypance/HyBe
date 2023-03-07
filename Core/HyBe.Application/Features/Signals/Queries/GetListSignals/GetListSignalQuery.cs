using System;
using HyBe.Domain.Contracts.Signals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Signals.Queries;

public class GetListSignalQuery : IRequest<IResult>
{
    public GetListSignalRequest Request { get; set; }

    public GetListSignalQuery(GetListSignalRequest request)
    {
        Request = request;
    }
}

