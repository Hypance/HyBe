using System;
using HyBe.Domain.Contracts.Enums;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Enums.Queries;

public class GetByIdEnumQuery : IRequest<IResult>
{
    public GetByIdEnumRequest Request { get; set; }

    public GetByIdEnumQuery(GetByIdEnumRequest request)
    {
        Request = request;
    }
}