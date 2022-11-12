using MediatorPatternAPI.Models;
using MediatorPatternAPI.Queries;
using MediatorPatternAPI.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Handlers
{
    public class ListUsersQueryHandler : IRequestHandler<ListUsersQuery, ICollection<User>>
    {
        private readonly IUserService _userService;

        public ListUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ICollection<User>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userService.ListUsers();
        }
    }
}
