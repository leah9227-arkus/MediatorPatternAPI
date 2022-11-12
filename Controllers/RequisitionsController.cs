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
    public class RequisitionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RequisitionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListRequisitions()
        {
            var listRequisitionsQuery = new ListRequisitionsQuery();
            var response = await _mediator.Send(listRequisitionsQuery);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequisition(int id)
        {
            var getRequisitionQuery = new GetRequisitionQuery(id);
            var response = await _mediator.Send(getRequisitionQuery);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequisition([FromBody] CreateRequisitionCommand createRequisitionCommand)
        {
            var response = await _mediator.Send(createRequisitionCommand);
            return Ok(response);
        }
    }
}
