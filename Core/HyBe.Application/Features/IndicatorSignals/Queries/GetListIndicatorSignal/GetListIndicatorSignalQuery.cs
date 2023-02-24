using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.IndicatorSignals.Queries.GetListIndicatorSignal;
public class GetListIndicatorSignalQuery : IRequest<IResult>
{
    public GetListIndicatorSignalRequest Request { get; set; }

    public GetListIndicatorSignalQuery(GetListIndicatorSignalRequest request)
    {
        Request = request;
    }
}