using MediatR;

namespace HyBe.Application.Features.AuthorizationEndpoint.Queries.GetRolesToEndpoint
{
    public class GetRolesToEndpointQueryRequest: IRequest<GetRolesToEndpointQueryResponse>
    {
        public string Code { get; set; }
        public string Menu { get; set; }
    }
}