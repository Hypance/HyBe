using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyBe.Application.Abstractions.Services;
using MediatR;

namespace HyBe.Application.Features.AppUser.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, GetAllUsersQueryResponse>
    {
        readonly IUserService _userService;

        public GetAllUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetAllUsersQueryResponse> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllUsersAsync(request.Page, request.Size);
            return new()
            {
                Users = users,
                TotalUsersCount = _userService.TotalUsersCount
            };
        }
    }
}