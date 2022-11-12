using MediatorPatternAPI.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int UserId { get; set; }

        public GetUserByIdQuery(int userId)
        {
            UserId = userId;
        }
    }
}
