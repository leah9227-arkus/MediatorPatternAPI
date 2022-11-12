using MediatorPatternAPI.Commands;
using MediatorPatternAPI.Models;
using MediatorPatternAPI.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListUsers()
        {
            var listUsersQuery = new ListUsersQuery();
            var users = await _mediator.Send(listUsersQuery);
            return Ok(users);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserByEmail(int userId)
        {
            var userQuery = new GetUserByIdQuery(userId);
            var user = await _mediator.Send(userQuery);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand createUserCommand)
        {
            var response = await _mediator.Send(createUserCommand);
            return Ok(response);
        }
    }
}
