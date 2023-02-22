using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.IndicatorSignals.Queries.GetByIdIndicatorSignal;

public class GetByIdIndicatorSignalQuery : IRequest<IResult>
{
    public GetByIdIndicatorSignalRequest Request { get; set; }

    public GetByIdIndicatorSignalQuery(GetByIdIndicatorSignalRequest request)
    {
        Request = request;
    }
}
