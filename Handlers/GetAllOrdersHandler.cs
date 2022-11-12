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
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, ICollection<Order>>
    {
        private readonly IOrdersService _ordersService;

        public GetAllOrdersHandler(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        public async Task<ICollection<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var response = await _ordersService.ListOrders();
            return response;
        }
    }
}
