using System;
using HyBe.Domain.Contracts.Enums;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Enums.Queries;

public class GetListEnumQuery : IRequest<IResult>
{
    public GetListEnumRequest Request { get; set; }

    public GetListEnumQuery(GetListEnumRequest request)
    {
        Request = request;
    }
}

