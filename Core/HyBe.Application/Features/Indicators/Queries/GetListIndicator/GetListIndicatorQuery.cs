using System;
using HyBe.Domain.Contracts.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Indicators.Queries;

public class GetListIndicatorQuery : IRequest<IResult>
{
    public GetListIndicatorRequest Request { get; set; }

    public GetListIndicatorQuery(GetListIndicatorRequest request)
    {
        Request = request;
    }
}

