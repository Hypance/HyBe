using System;
using HyBe.Domain.Contracts.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Indicators.Queries;

public class GetByIdIndicatorQuery : IRequest<IResult>
{
    public GetByIdIndicatorRequest Request { get; set; }

    public GetByIdIndicatorQuery(GetByIdIndicatorRequest request)
    {
        Request = request;
    }
}