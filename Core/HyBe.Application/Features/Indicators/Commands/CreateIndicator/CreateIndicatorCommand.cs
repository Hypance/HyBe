using System;
using HyBe.Domain.Contracts.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;


namespace HyBe.Application.Features.Indicators.Commands;

public class CreateIndicatorCommand : IRequest<IResult>
{
    public CreateIndicatorRequest Request { get; set; }

    public CreateIndicatorCommand(CreateIndicatorRequest request)
    {
        Request = request;
    }
}