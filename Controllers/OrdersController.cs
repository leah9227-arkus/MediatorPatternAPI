using MediatorPatternAPI.Commands;
using MediatorPatternAPI.Models;
using MediatorPatternAPI.Queries;
using MediatorPatternAPI.Services;
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
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var query = new GetAllOrdersQuery();
            var mediatorResponse = await _mediator.Send(query);

            return Ok(mediatorResponse);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderById(int orderId)
        {
            var query = new GetOrderByIdQuery(orderId);
            var response = await _mediator.Send(query);

            return Ok(response);
        }

        [HttpPost]
        public async Task<Order> CreateOrder([FromBody] CreateOrderCommand createOrderCommand)
        {
            var response = await _mediator.Send(createOrderCommand);
            return response;
        }
    }
}
