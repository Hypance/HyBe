using MediatR;

namespace HyBe.Application.Features.AppUser.Queries.GetRolesToUser
{
    public class GetRolesToUserQueryRequest : IRequest<GetRolesToUserQueryResponse>
    {
        public string UserId { get; set; }
    }
}